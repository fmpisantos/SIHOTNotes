servico para obter info do hotel logged/atual

Create a service that retrieves information regarding the current loggedin hotel.
The fields should be: 
objID, uuid, hotelNo, name1, name2, codeinternal, hotelRegion, street, pobox, country, subcountry, subsubcountry, postcode, location, location2, phone, email1;

Hotel_current_Get
<Column Alias="Hotel"	FieldName="objID"		Name="HOTEL-OBJID"/>
<Column Alias="Hotel" 	FieldName="uuid" />
<Column Alias="Hotel" 	FieldName="hotelNo" />
<Column Alias="Hotel" 	FieldName="name1" />
<Column Alias="Hotel" 	FieldName="name2" />
<Column Alias="Hotel" 	FieldName="codeinternal" />
<Column Alias="Hotel" 	FieldName="hotelRegion"/>
<Column Alias="Hotel" 	FieldName="street" />
<Column Alias="Hotel" 	FieldName="pobox" />
<Column Alias="Hotel" 	FieldName="country" />
<Column Alias="Hotel" 	FieldName="subcountry" />
<Column Alias="Hotel" 	FieldName="subsubcountry" />
<Column Alias="Hotel" 	FieldName="postcode" />
<Column Alias="Hotel" 	FieldName="location" />
<Column Alias="Hotel" 	FieldName="location2" />
<Column Alias="Hotel" 	FieldName="phone" />
<Column Alias="Hotel" 	FieldName="email1" />

extend package da API com um get hotel
