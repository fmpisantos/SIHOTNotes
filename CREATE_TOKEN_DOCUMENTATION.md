---
title: INTR Create token
titleshort: Create token
layout: reference.hbs
intrlist: true
date: 2024-6-3
---

# Create token

This request is used to update a creditcard with token information.

## Operationcode: ``CREATE-TOKEN-REQUEST``

__``CREATE-TOKEN-REQUEST``__

### Direction

SIHOT.PMS ← SIHOT.WEB

### Message

This request is used to update a creditcard with token information.
```XML
<?xml version="1.0" encoding="ISO-8859-1"?>
<SIHOT-DOCUMENT>
    <VER>2.0</VER>
    <OC>CREATE-TOKEN-REQUEST</OC>
    <ID>1</ID>
    <TN>1</TN>
    <REFTYPE>EVENT</REFTYPE>
    <CARD-TYPE>VI</CARD-TYPE>
    <REFID>322</REFID> 
    <CCHANDLE>Test</CCHANDLE>
    <CCHANDLEVALIDUNTIL>2025-12-12</CCHANDLEVALIDUNTIL>
    <SERVICEPROVIDER>Visa</SERVICEPROVIDER>
    <EXT-ADD-REF>Test</EXT-ADD-REF>
    <CARD-NR>123123125</CARD-NR>
    <CARD-TEXT>Jane Doe</CARD-TEXT>
</SIHOT-DOCUMENT>
```

### Elements/Attributes

<table>
<thead>
<tr class="header">
<th>Elements</th>
<th>Description</th>
<th>Data type</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>REFTYPE</td>
<td>
<table>
<tbody>
<tr>
<td>CARD</td>
<td>Updates card with token information.</td>
</tr>
<tr>
<td>RESERVATION</td>
<td>Updates reservation creditcard with token information.</td>
</tr>
<tr>
<td>GUEST</td>
<td>Updates guest creditcard with token information.</td>
</tr>
<tr>
<td>EVENT</td>
<td>Updates event creditcard with token information.</td>
</tr>
</tbody>
</table>
</td>
<td>String</td>
</tr>
<tr class="even">
<td>REFID</td>
<td>ObjID of referenced REFTYPE</td>
<td>Unsigned long</td>
</tr>
<tr class="odd">
<td>CARD-TYPE</td>
<td><a href="https://partner.sihot.com/payengine/usage/2_generalInformation/#cardtypes">Card type</a></td>
<td>String</td>
</tr>
<tr class="even">
<td>CCHANDLE</td>
<td>Credit card handle/token/key/pseudo card number</td>
<td>String</td>
</tr>
<tr class="odd">
<td>CCHANDLEVALIDUNTIL</td>
<td>Handle is valid until this date</td>
<td>Date</td>
</tr>
<tr class="even">
<td>SERVICEPROVIDER</td>
<td><a href="https://partner.sihot.com/payengine/usage/2_generalInformation/#service-providers">Service provider</a></td>
<td>String</td>
</tr>
<tr class="odd">
<td>EXT-ADD-REF</td>
<td>Additional field to store information from payment provider</td>
<td>String</td>
</tr>
<tr class="even">
<td>CARD-NR</td>
<td>Credit card number</td>
<td>String</td>
</tr>
<tr class="odd">
<td>CARD-TEXT</td>
<td>Text associated with credit card</td>
<td>String</td>
</tr>
</tbody>
</table>

### Answer
```XML
<?xml version="1.0" encoding="ISO-8859-1"?>
<SIHOT-DOCUMENT>
	<OC>CREATE-TOKEN-ANSWER</OC>
	<ID>1</ID>
	<TN>1</TN>
	<RC>0</RC>
</SIHOT-DOCUMENT>
```
If an error occurs during the update card token information, an error message is sent
to SIHOT.PMS. An error code “0” means that no error occurred.

```XML
<?xml version="1.0" encoding="ISO-8859-1"?>
<SIHOT-DOCUMENT>
	<OC>RES</OC>
	<ID>1</ID>
	<TN>1</TN>
	<RC>1</RC>
	<MSG>error message</MSG>
</SIHOT-DOCUMENT>
```

