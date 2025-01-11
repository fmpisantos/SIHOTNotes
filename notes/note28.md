## Comprehensive Hotel Functions Test Spreadsheet

### Date Functions
A1: =SIHOTGETDATE("2024-11-18", "TestCmd", "TestFS")

### Turnover Functions
B1: =SIHOTGETTURNOVER(1, 257001, TRUE, "2024-11-01", "2024-11-18")
B2: =SIHOTGETTURNOVERESC(1, 257001)

### Z-Statistics Functions
C1: =SIHOTDOGETZSTATISTIC(FALSE, 1, "Revenue", "", "2024-01-01", "2024-12-31")
C2: =SIHOTDOGETZSTATISTIC(TRUE, 1, "Budget", "", "2024-01-01", "2024-12-31")

### Hotel Information Functions
D1: =SIHOTGETHOTELINFO(1)
D2: =SIHOTGETGUESTINFO("123456", "Name")

### Forecast Functions
E1: =SIHOTGETINITFORECAST(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31")
E2: =SIHOTGETINITROOMS(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31")
E3: =SIHOTGETINITGUESTFORECAST(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31", "123456", TRUE)

### Rooms on Books Functions
F1: =SIHOTGETINITROOMS(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31")
F2: =SIHOTGETINITROOMS(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31")
F3: =SIHOTGETDATEVALUROOMS("Date1=10;Date2=20", "2024-01-01")

### Pool and Text Functions
G1: =SIHOTGETPOOL(1, 1, "Type")
G2: =SIHOTGETTURNOVERESC(1, 257001)
G3: =SIHOTGETTEXT(1, "Type")
G4: =SIHOTGETLONGTEXT(1, "ShortText", "Type")
G5: =SIHOTGETEVENTROOMINFO(1, "2024-11-18", "10:00", "RoomA", "Format")

### Yield Forecast Functions
H1: =SIHOTGETYIELDFORECAST(1, "2024-11-18", "Full", "GRP", "Market")
H2: =SIHOTGETYIELDFORECAST2(1, "2024-11-18", "2024-12-31", "Full", "GRP", "Market")
H3: =SIHOTGETYIELDFORECASTDATERANGE(1, "2024-11-18", "2024-11-20", "2024-12-31", "Full", "GRP", "Market")

### Guest and Availability Functions
I1: =SIHOTGETGUESTSTATISTIC(1, "Type", "Subtype", "2024-01-01", "2024-12-31", "123456", TRUE)
I2: =SIHOTGETAVAILABILITY(1, "Room", "Type", "Include", "2024-01-01", "2024-12-31")

### Restrictions and Segmentation Functions
J1: =SIHOTGETRESTRICTIONS(1, "Area", "Key", "2024-01-01", "2024-12-31")
J2: =SIHOTGETINITSEGMENTATIONFORECAST(1, "Sales", "Full", "GRP", "Room", "", "2024-01-01", "2024-12-31", "2024-01-01", "2024-12-31", "123456", TRUE)
J3: =SIHOTGETINITSEGMENTATION(1, "Sales", "2024-01-01", "2024-12-31", "Revenue", "")
J4: =SIHOTGETSEGMENTATION("Key1", "Key2", "Key3", "Key4", "")

### Currency Exchange Functions
K1: =SIHOTGETPURCHASECURRENCYEXCHANGE("USD", "100", "2024-11-18")
K2: =SIHOTGETSELLCURRENCYEXCHANGE("EUR", "100", "2024-11-18")

### Price Functions
L1: =SIHOTDOPRICE("Key", "2024-01-01", "2024-12-31", {10,20,30,40,50,60,70,80,90,100,110,120,130,140,150})
L2: =SIHOTDOLOADPRICES()
L3: =SIHOTDORESETPRICES()

## Implementation Notes
- Replace placeholder values with actual data
- Ensure custom functions are properly configured
- Some functions may require specific system setup
