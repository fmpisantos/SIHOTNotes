POST http://172.24.2.82:8080/IFS/S_IF_TFLEX_V001 HTTP/1.1
Content-Type: text/xml; charset=utf-8
SOAPAction: ""
Host: 172.24.2.82:8080
Content-Length: 413
Expect: 100-continue
Accept-Encoding: gzip, deflate

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/"><s:Body xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><AuthenticateRequest xmlns="http://www.gubse.com/IFS/S_IF_TFLEX_V001.xsd"><AuthenticationInfos><user>GitExtensions</user><password>GitExtensions2022!</password><hotel>1</hotel></AuthenticationInfos></AuthenticateRequest></s:Body></s:Envelope>

POST http://172.24.2.82:8080/IFS/S_IF_TFLEX_V001 HTTP/1.1
Content-Type: text/xml; charset=utf-8
SOAPAction: ""
Host: 172.24.2.82:8080
Content-Length: 566
Expect: 100-continue
Accept-Encoding: gzip, deflate

<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/"><s:Body xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><S_TASK_SEARCH_V001Request xmlns="http://www.gubse.com/IFS/S_IF_TFLEX_V001.xsd"><Authentication><SecurityID>X9j6NSy51x99CmXFseAOs0yB1E+m8QLyBnFu/2dKF6dWraSatGtUh5gh8QeWN4a7Rl2ghe7JWMLINbxdIToFBqjDIengiPGWUaBgTTw0xrlOqPfQ6vZHJdolzP56Q81E</SecurityID></Authentication><TASK-SEARCH><status>WIP,WAC</status><assignedto>FS1</assignedto></TASK-SEARCH></S_TASK_SEARCH_V001Request></s:Body></s:Envelope>
