public class CustomXmlInputFormatter : Microsoft.AspNetCore.Mvc.Formatters.InputFormatter
{
    public class IgnoreNameSpaceXmlReader : XmlTextReader
    {
        public IgnoreNameSpaceXmlReader(TextReader reader) : base(reader) {
            _NamespaceURI = string.empty;
        }
        public IgnoreNameSpaceXmlReader(TextReader reader, string namespace) : base(reader) {
            _NamespaceURI = namespace;
        }
        private string _NamespaceURI {get; set;}
        public override string NamespaceURI => _NamespaceURI;
    }

    public CustomXmlInputFormatter()
    {
        SupportedMediaTypes.Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/xml"));
        SupportedMediaTypes.Add(Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/xml"));
    }

    public override async Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
    {
        using var reader = new StreamReader(context.HttpContext.Request.Body);
        string xmlContent = await reader.ReadToEndAsync();
        var result = DeserializeXML(xmlContent, context.ModelType);
        return await InputFormatterResult.SuccessAsync(result);
    }

    private object? DeserializeXML(string xmlContent, Type type)
    {
        var typeAttribute = (XmlTypeAttribute)type.GetCustomAttribute(typeof(XmlTypeAttribute));
        string expectedNamespace = typeAttribute?.Namespace ?? "SIHOTNotifications";

        using var reader = new StringReader(xmlContent);
        var serializer = new XmlSerializer(type);
        using var xmlReader = new IgnoreNameSpaceXmlReader(reader, expectedNamespace);
        return serializer.Deserialize(xmlReader);
    }
}
