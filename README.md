#### Preparando o ambiente
##### Criando o banco de dados
Abra o terminal, navegue para a pasta onde baixou o projeto e execute o comando abaixo:
```
dotnet ef database update --project .\ContainRs.WebApp\ContainRs.WebApp.csproj --startup-project .\ContainRs.WebApp\ContainRs.WebApp.csproj
```
O comando deverá criar o banco de dados e as tabelas necessárias para o funcionamento do projeto.

Projeto para estudo de Clean Architecture do curso da Alura: https://cursos.alura.com.br/formacao-arquitetura-net-codificacao-deploy-nuvem