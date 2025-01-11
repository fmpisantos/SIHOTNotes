IWalletService - GoogleWalletService, AppleWalletService
	- CreatePass
GoogleController
 
	/create
 
		- CreatePass
		- Return url 
wallet.sihot.com/google/create
wallet.sihot.com/apple/create
 
Input:
 
{
 
	"hotel" : guid,
	"passType" : 
	"hotelName":
	"address":
	"from"
	"to"
	"firstName"
	"lastName"
	"qrcodecontent"
}
 
- check SIHOT side. utc? timezone? from/to
- TKO (fiscalization API)
 
Output:
 
{
	"url": https://pay.google/save/[aa]
} - redirect directly
 
{
	"content": wallet.sihot.com/apple/[aa].pkpass
 
} - immediate download
