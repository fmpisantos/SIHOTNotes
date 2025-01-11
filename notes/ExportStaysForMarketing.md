# Stays for Marketing Export

## Description

The export refers to guests who have already left. Therefore, it must be created for dates in the past.  
Only guests with a post-stay e-mail address are included in the export.
For a more detailed description [click here](https://help.sihot.com/Nethelp/V1100.01.04.0063/EN/#!Documents/salescategory.htm).

## Configuration

To configure the fields that will be exported, the following registries can be adjusted:

#### Body (7636)

- **Class**: `staysformarketing`
- **Value**: `body`
- **Description**: Fields included in the export file.
- **Possible Values**:  
  - **Defaults**:  
    `OBJID;HN;HNAME;HSTREET;HCITY;CN;SN;STREET;COUNTRY;REGION;ADDRESS;ZIP;CITY;DOB;ROOM;ARRIVAL;DEPARTURE;GENDER;EMAIL;TITLE;RES-NO;GDS-NO;MC;SOURCE;MEDIUM;CHANNEL;NN1;LANGUAGE;POST-STAY-ID;POST;RES-CREATION;SALES-DATE;PRICE-SEGMENT;PRICE-CATEGORY;SERVICEID;SERVICECODE;ROOMNIGHTS;ROOM-CATEGORY;QUALITY-FLAG`
  - **If Hotel Uses Complex**:  
    `COMPLEX;COMPLEX-DESC`
  - **Optionals**:  
    `PHONE-NUMBER;MOBILE-NUMBER`

#### Body Mapping Gender (40942)

- **Class**: `staysformarketing`
- **Value**: `bodymappinggender`
- **Description**: Rename gender values in the export.
- **Example**:  
  `"M=Male;F=Female;X=Other"`

#### Header (7635)

- **Class**: `staysformarketing`
- **Value**: `header`
- **Description**: Header for the export file.
- **Possible Values**:  
  - **Defaults**:  
    `OBJID;HN;HNAME;HSTREET;HCITY;CN;SN;STREET;COUNTRY;REGION;ADDRESS;ZIP;CITY;DOB;ROOM;ARRIVAL;DEPARTURE;GENDER;EMAIL;TITLE;RES-NO;GDS-NO;MC;SOURCE;MEDIUM;CHANNEL;NN1;LANGUAGE;POST-STAY-ID;POST;RES-CREATION;SALES-DATE;PRICE-SEGMENT;PRICE-CATEGORY;SERVICEID;SERVICECODE;ROOMNIGHTS;ROOM-CATEGORY;QUALITY-FLAG`
  - **If Hotel Uses Complex**:  
    `COMPLEX;COMPLEX-DESC`
  - **Optionals**:  
    `PHONE-NUMBER;MOBILE-NUMBER`

#### Header Mapping (40941)

- **Class**: `staysformarketing`
- **Value**: `headerMapping`
- **Description**: Rename headers for the export.
- **Example**:  
  `"OBJID=GUEST-OBJID;HN=HOTEL-NR"`

#### Omit Header (8157)

- **Class**: `staysformarketing`
- **Value**: `omitHeader`
- **Description**: Omit the header from the export file.

#### Path (1091)

- **Class**: `staysformarketing`
- **Value**: `path`
- **Description**: Specify the file path for the export.

#### File Prefix (9814)

- **Class**: `staysformarketing`
- **Value**: `filePrefix`
- **Default**: `stays`

#### Encoding (40938)

- **Class**: `staysformarketing`
- **Value**: `useUTF8`
- **Description**: Set the export file encoding to UTF-8.

#### Date Format (8471)

- **Class**: `staysformarketing`
- **Value**: `dateformat`
- **Default**: `ISO8601`
- **Description**: Define the format of dates in the export file.
