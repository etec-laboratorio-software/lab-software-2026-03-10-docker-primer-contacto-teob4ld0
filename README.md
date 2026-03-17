¿Qué es ésto?
Si no lo sabes no sos mi profe, así que te respondo con una pregunta.
¿Qué te importa?

Siguiendo a los prerequisitos:
- Una computadora
- Docker

Siguiendo a lo que tenes que hacer:

Primero: Pegá en una terminal el siguiente comando:
git clone git@github.com:etec-laboratorio-software/lab-software-2026-03-10-docker-primer-contacto-teob4ld0.git
(Si no tenes ssh configurado, está en vos. Pero se que don Daniel Quinteros lo tiene configurado)

Segundo: Pegá en la misma terminal lo siguiente:
cd lab-software-2026-03-10-docker-primer-contacto-teob4ld0

Segundo.5: Debes tener docker corriendo para el tercer paso, aparte de hacerte los permisos en caso de que no los tengas:
sudo usermod -aG docker $USER

Tercero: Pegá el siguiente comando en la terminal:

docker compose up -d

Cuarto: Sentite orgulloso.

Quinto: en distintas pestañas del navegador que más desees pegá:
(Pestaña 1, acá va a estar el backend) localhost:5000/allgood
(Pestaña 2, acá va a estar el frontend) localhost:8000

Sexto: Disfrutá de no poder hacer nada con eso, pero dockerizado está.