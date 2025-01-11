public class CustomXmlInputFormatter : Microsoft.AspNetCore.Mvc.Formatters.InputFormatter
{
    public CustomXmlInputFormatter()
    {
        SupportedMediaTypes.Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/xml"));
        SupportedMediaTypes.Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/xml"));
    }

    private XmlSerializer CreateNamespaceAgnosticSerializer(Type type)
    {
        var overrides = new XmlAttributeOverrides();
        ProcessType(type, overrides, new HashSet<Type>());
        return new XmlSerializer(type, overrides);
    }

    private void ProcessType(Type type, XmlAttributeOverrides overrides, HashSet<Type> processedTypes)
    {
        if (!processedTypes.Add(type))
            return;

        var typeAttributes = new XmlAttributes
        {
            XmlType = new XmlTypeAttribute { Namespace = "" }
        };
        overrides.Add(type, typeAttributes);

        foreach (var property in type.GetProperties())
        {
            var propertyAttributes = new XmlAttributes();

            propertyAttributes.XmlElements.Add(new XmlElementAttribute { Namespace = "" });
            overrides.Add(type, property.Name, propertyAttributes);

            var propertyType = property.PropertyType;

            if (propertyType.IsGenericType &&
                (typeof(IEnumerable<>).IsAssignableFrom(propertyType.GetGenericTypeDefinition())))
            {
                var elementType = propertyType.GetGenericArguments()[0];
                ProcessType(elementType, overrides, processedTypes);
            }

            else if (propertyType.IsArray)
            {
                var elementType = propertyType.GetElementType();
                ProcessType(elementType, overrides, processedTypes);
            }

            else if (!propertyType.IsPrimitive && propertyType != typeof(string))
            {
                ProcessType(propertyType, overrides, processedTypes);
            }
        }
    }

    public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
    {
        var request = context.HttpContext.Request;
        if (!request.Body.CanRead)
        {
            return await InputFormatterResult.FailureAsync();
        }

        try
        {
            using (var reader = new StreamReader(request.Body))
            {
                var xml = await reader.ReadToEndAsync();
                var type = context.ModelType;
                var serializer = CreateNamespaceAgnosticSerializer(type);

                using (var stringReader = new StringReader(xml))
                using (var xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings()))
                {
                    var result = serializer.Deserialize(xmlReader);
                    return await InputFormatterResult.SuccessAsync(result);
                }
            }
        }
        catch (Exception ex)
        {
            context.ModelState.TryAddModelError(context.ModelName, ex.Message);
            return await InputFormatterResult.FailureAsync();
        }
    } 
}
