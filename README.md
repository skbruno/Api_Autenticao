[csharp-image]:https://img.shields.io/badge/charp-^2022-blue

[postgresql-image]:https://img.shields.io/badge/mysql

# ↪︎ Api Autenticação ↩︎

Funcionalidades:

✅ Criação de usuário com armazenamento da senha utilizando hash no banco de dados.
✅ Login de usuário com autenticação via JWT.
✅ Atualização de dados do usuário.
✅ Exclusão de usuário.

## 😎 Quero mexer nesse projeto preciso de que?
- Visual Studio - C# = .NET 8.0
- MySQL

### Dependencias e versão do projeto: 
- package System.IdentityModel.Tokens.Jwt == version 6.30.0
- package Microsoft.IdentityModel.Tokens == version 6.30.0
- package Pomelo.EntityFrameworkCore.MySql == version 8.0.0
- package Swashbucle.AspNetCore == version 6.6.2
- package EntityFrameworkCore.Design == 8.0.1
- package Microsoft.AspNetCore.Authentication.JwtBearer == 7.0.14


📚 Rotas da API

➤ Cadastro de Usuário
POST /api/usuarios

{
  "nome": "Seu Nome",
  "email": "seu@email.com",
  "senha": "suaSenha123"
}

➤ Login de Usuário com autenticação
POST /api/login

{
  "email": "seu@email.com",
  "senha": "suaSenha123"
}

➤ Atualização de Usuário - EM CONSTRUÇÃO
PUT 

➤ Exclusão de Usuário - EM CONSTRUÇÃO
DELETE 
