# How to run sinetres/intr

- Open cmd in the instalation directory
- ```bash
    .\Sstart.exe -b
    ```
- ```bash
    sinetre.exe "" 15000 INTR -h localhost -d 1 -s 1 -bs 5 -f 1 -n localhost -NORC 1 -NS 1 -ID 1
    ```
    or if already ran the comand above once you can simply run:
    ```bash
    .\Scmd.exe stc INTR
    ```
- Create new file in the instalation folder:
    - esb_config.xml
    ```xml
    <SIHOT-DOCUMENT>
        <ServiceProxy name="INTR">
            <path>/INTR/*</path>
            <request>
                <lua><![CDATA[
                    ]]>
                </lua>
            </request>
            <target uri="TCP://localhost:14777" eom="EOT" />
            <response>
                <lua><![CDATA[
                    ]]>
                </lua>
            </response>
        </ServiceProxy>
        <ServiceProxy name="SXML">
            <path>/SXML/*</path>
            <request>
                <lua><![CDATA[
                    ]]>
                </lua>
            </request>
            <target uri="TCP://localhost:14772" eom="EOT" />
            <response>
                <lua><![CDATA[
                    ]]>
                </lua>
            </response>
        </ServiceProxy>
        <ServiceProxy name="DUMP">
            <path>/DUMP*</path>
            <request>
                <lua file="dumpXML.lua"/>
            </request>
        </ServiceProxy>
    </SIHOT-DOCUMENT>
    ```
- ```bash
    .\ESB.EXE "" 15000 ESB -d 1 -hp 8889 -tp 14782 -ap 4445
    ```
    or if already ran the command above once you can simply run:
    ```bash
    .\Scmd.exe stc ESB
    ```

## Example request:
To check if sinetres is running correctly do a POST request to localhost:8080/INTR with the following body:
```xml
<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<SIHOT-Document xmlns:S="http://schemas.xmlsoap.org/soap/envelope/" xmlns:ns2="http://www.gubse.com/intr/2009/02">
    <VER>2.1</VER>
    <OC>GUEST-SEARCH</OC>
    <TN>167</TN>
    <FLAGS>GET-SETTLEMENT-PROFILES</FLAGS>
</SIHOT-Document>
```
