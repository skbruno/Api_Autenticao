# ↪︎ Api Autenticação ↩︎

![csharp-image](https://img.shields.io/badge/csharp-^2022-blue)
![mysql-image](https://img.shields.io/badge/mysql)

## 📌 Funcionalidades

✅ Criação de usuário com armazenamento seguro da senha (utilizando hash) no banco de dados.  
✅ Login de usuário com autenticação via **JWT (JSON Web Token)**.  
✅ Atualização de dados do usuário (em construção).  
✅ Exclusão de usuário (em construção).  

## 🚀 Tecnologias Utilizadas

- **.NET 8.0** com **C#**  
- **MySQL** como banco de dados  
- **JWT** para autenticação segura  

## 😎 Quero mexer nesse projeto, preciso de quê?

- **Visual Studio** com suporte a **.NET 8.0**  
- **MySQL** instalado e configurado  

### 📦 Dependências e Versões do Projeto:

- `System.IdentityModel.Tokens.Jwt` - versão **6.30.0**  
- `Microsoft.IdentityModel.Tokens` - versão **6.30.0**  
- `Pomelo.EntityFrameworkCore.MySql` - versão **8.0.0**  
- `Swashbuckle.AspNetCore` - versão **6.6.2**  
- `Microsoft.EntityFrameworkCore.Design` - versão **8.0.1**  
- `Microsoft.AspNetCore.Authentication.JwtBearer` - versão **7.0.14**  

### 📚 Rotas da API
➤ Cadastro de Usuário
POST /api/usuarios

json
Copiar
Editar
{
  "nome": "Seu Nome",
  "email": "seu@email.com",
  "senha": "suaSenha123"
}
➤ Login de Usuário com autenticação
POST /api/login

json
Copiar
Editar
{
  "email": "seu@email.com",
  "senha": "suaSenha123"
}
➤ Atualização de Usuário (Em Construção)
PUT /api/usuarios/:id

json
Copiar
Editar
{
  "nome": "Novo Nome"
}
➤ Exclusão de Usuário (Em Construção)
DELETE /api/usuarios/:id
