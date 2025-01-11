/**
 * Base64 encode a string
 * @param str The string to encode
 * @returns The base64 encoded string
 */
function base64Encode(str) {
  const chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=';
  let output = '';
  let i = 0;

  while (i < str.length) {
    const byte1 = str.charCodeAt(i++) & 0xFF;
    const byte2 = i < str.length ? str.charCodeAt(i++) & 0xFF : 0;
    const byte3 = i < str.length ? str.charCodeAt(i++) & 0xFF : 0;

    output += chars.charAt(byte1 >> 2);
    output += chars.charAt(((byte1 & 0x03) << 4) | (byte2 >> 4));
    output += i <= str.length ? chars.charAt(((byte2 & 0x0F) << 2) | (byte3 >> 6)) : '=';
    output += i <= str.length ? chars.charAt(byte3 & 0x3F) : '=';
  }

  return output;
}

/**
 * Get hotel name
 * @customfunction GetHotelName
 * @param hotelNr Hotel number
 * @returns Hotel name.
 */
export async function GetHotelName(hotelNr) {
  const url = 'http://localhost:8080/sixmlrpc';
  const username = 'fs'; 
  const password = '@Abc.123'; 

  const authHeader = base64Encode(`${username}:${password}`);

  const xmlBody = `<?xml version="1.0" ?>
<methodCall>
<methodName>GetHotelInfo</methodName>
<params>
<param>
<value>
<int>${hotelNr}</int>
</value>
</param>
<param>
<value>noValue</value>
</param>
<param>
<value>noValue</value>
</param>
</params>
</methodCall>`;


  return new Promise(function (resolve, reject) {
    fetch(url, {
      method: "POST",
      headers: {
        'Content-Type': 'application/xml',
        'Authorization': `Basic ${authHeader}`,
      },
      body: xmlBody
    })
      .then(function (response){
        return response.text();
      }
      )
      .then(function (data) {
        resolve(data);
      })
      .catch(function(error) {
        reject(JSON.stringify(error));
      })
  })
}

const test = async() => {
  console.log(await GetHotelName(1));
}

test()
