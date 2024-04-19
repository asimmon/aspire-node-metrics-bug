import express from "express";

const port = process.env.PORT ?? 3000;

const app = express();

app.get("/", (_req, res) => res.send("Hello world!"));

app.listen(port, () => {
  console.log(`Carol service listening at http://localhost:${port}`);
});
