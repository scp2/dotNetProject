# Repositório do curso de introdução ao .NET

## Instalando o SDK(.net core 3.1)
> Comandos utilizados para realizar a instalação do SDK da plataforma de desenvolvimento .NET core 3.1.

1. Instalar o SDK utilizando o DNF ```$ sudo dnf install dotnet-sdk-3.1```.
2. Verificar a versão do SDK ```$ dotnet --version```.
3. Devera ser exibito ``` 3.1.110```.

### First .NET console app 

1. Executar o comando new do SDK para criar o console app ```$ dotnet new console -n appName```
2. No diretório onde o comando for executado, sera criado um novo diretório com o nome passado para o projeto do console app.
3. Para executar o projeto primeiro o build```$ dotnet build``` 
4. Depois o run ```$ dotnet run```
5. Deverá ser impresso na tela ```Hello World!```
6. Utilizar o comando ```$ dotnet new gitignore``` para seguir integrando o projeto ao git

