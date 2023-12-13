# TrybeBets

Este projeto consiste em uma API para o site de apostas TrybeBets, originalmente desenvolvido como um monolito pela equipe do curso Trybe. O objetivo principal foi transformar a aplicação de monolito para microservices, dividindo as responsabilidades e permitindo comunicação eficiente entre os microservices usando HttpClient.

## Tecnologias Utilizadas

- .NET 6.0
- FluentAssertions.AspNetCore.Mvc 4.2.0
- Microsoft.AspNetCore.Authentication 2.2.0
- Microsoft.AspNetCore.Authentication.JwtBearer 6.0
- Microsoft.EntityFrameworkCore 7.0.4
- Microsoft.EntityFrameworkCore.Design 7.0.4
- Microsoft.EntityFrameworkCore.SqlServer 7.0.4
- Swashbuckle.AspNetCore 6.2.3

## Estrutura do Projeto

A estrutura do projeto é organizada em microservices, cada um com sua responsabilidade específica. As dependências entre os serviços são gerenciadas utilizando HttpClient.

## Configuração

Certifique-se de ter as dependências instaladas e o ambiente configurado corretamente:

```bash
dotnet restore
```

## Migration

É necessario executar as migrations em pelo menos um dos projetos, para que o banco de dados seja criado.
Para isso, dentro da pasta `Trybets/src/TryBets`, execute o seguinte comando:

```bash
dotnet ef migrations add NomeDaMigracao

```

```bash
dotnet ef database update
```

## Execução

Monolith
Dentro da pasta `Trybets/src/TryBets`, para executar a API, utilize o seguinte comando:

```bash
dotnet run
```

Para executar em microservices, faça o mesmo em cada um dos projetos dentro da pasta `Trybets/src`. com exeção do TrybeBets.
Também é possivel fazer um Gateway para executar todos os microservices de uma vez, mas isso tera que ser desenvolvido.

## Contato

Para entrar em contato com a equipe, envie um e-mail para - <a href='mailto:gabrielferdev@gmail.com'>Gabriel</a>

## Docker

Todas as aplicações de microservices têm Dockerfiles dentro de seus diretórios; no entanto, a de monólito não tem. Voce pode executar os microservicer usando o docker-compose, mas para executar o monólito, voce tera que executar o comando `dotnet run` dentro da pasta `Trybets/src/TryBets`.
