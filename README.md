# mvcr

Projeto de console em C# com CRUD de pessoas, organizado em camadas `Model`, `View`, `Controller` e `Repository`.

## Funcionalidades

- Criar pessoa (`nome`, `idade`)
- Alterar pessoa por �ndice
- Deletar pessoa por �ndice
- Listar pessoas cadastradas

## Estrutura do projeto

- `Program.cs`: menu principal e fluxo da aplica��o.
- `view/Pessoa.cs`: intera��o com usu�rio (entrada/sa�da no console).
- `controller/Pessoa.cs`: orquestra as a��es entre view e model.
- `model/Pessoa.cs`: regras de dom�nio e opera��es de CRUD.
- `repository/Pessoa.cs`: armazenamento em mem�ria (`List<Pessoa>` est�tica).

## Pr�-requisitos

- .NET SDK compat�vel com `net10.0` (definido em `mvcr.csproj`)

## Como executar

No diret�rio do projeto:

```bash
dotnet run
```

## Menu da aplica��o

Ao executar, o menu exibir�:

1. Criar
2. Alterar
3. Deletar
4. Listar
5. Encerrar

## Observa��es

- Os dados s�o mantidos apenas em mem�ria durante a execu��o.
- Ao encerrar o programa, a lista de pessoas � perdida.
- Altera��o e exclus�o usam �ndice da lista exibida em `Listar`.
