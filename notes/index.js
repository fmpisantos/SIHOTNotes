fetch("https://teamsantos.work/version")
  .then(response => response.text())
  .then(data => console.log(data))
  .catch(error => console.error("Error:", error));
