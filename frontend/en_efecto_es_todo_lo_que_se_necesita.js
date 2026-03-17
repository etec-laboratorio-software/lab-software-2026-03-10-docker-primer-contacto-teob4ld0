import http from "http";

const BASE = "http://api:8080";
const PORT = 8000;

http.createServer(async (req, res) => {
  const r1 = await fetch(`${BASE}/allgood`);
  const backend = await r1.text();

  const r2 = await fetch(`${BASE}/allgood/dbtest`);
  const db = await r2.text();

  res.writeHead(200, { "Content-Type": "text/plain" });
  res.end(`backend: ${backend}\ndb: ${db}\n`);
}).listen(PORT, () => console.log(`frontend escuchando en puerto ${PORT}`));
