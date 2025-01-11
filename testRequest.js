const axios = require('axios');

// URL for the POST request
const url = 'https://localhost:44368/google/guestpass';

// JSON body for the request
const payload = {
  hotel: "123",
  hotelName: "Hotel Test",
  address: "Rua Ramiro Ferrao",
  from: "2024-09-02",
  to: "2024-09-19",
  firstName: "Filipe",
  lastName: "Santos",
  qrcodecontent: "1981",
  PCIID: 654321,
  RESNO: 175992,
  RESUNR: 123123123,
  GRPNO: 987,
  Room: 123
};

// Headers for the request
const headers = {
  'Content-Type': 'application/json'
};

// Disable SSL verification (not recommended in production)
const https = require('https');
const agent = new https.Agent({ rejectUnauthorized: false });

async function sendRequest() {
  try {
    // Make the POST request
    const response = await axios.post(url, payload, {
      headers: headers,
      httpsAgent: agent
    });

    // Check the response status code
    if (response.status === 200) {
      console.log('Request successful!');
      console.log('Response:', response.data);
    } else {
      console.log(`Request failed with status code: ${response.status}`);
      console.log('Response:', response.data);
    }
  } catch (error) {
    console.error(`An error occurred: ${error.message}`);
  }
}

// Call the function to send the request
sendRequest();
