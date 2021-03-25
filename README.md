# Redis_Conexao_Basico

baixar a imagem do redis no docker: 
docker pull redis

Executar:
docker run --name local-redis -p 6379:6379 -d redis --network host

docker logs -f local-redis

docker exec -it local-redis /bin/bash

redis-cli
ping


no redis-cli digitar 
get "nome da chave"


Na conection string garantir que a conexão está no container certo, no caso indico usar "host.docker.internal"


Curl pra gravar
curl --location --request POST 'https://localhost:44330/api/Redis_Demo' \
--header 'Content-Type: application/json' \
--data-raw '{"key":"teste1","value":"teste 1 gravando"}'

Curl de consulta
curl --location --request GET 'https://localhost:44330/api/Redis_Demo?key=teste1'
