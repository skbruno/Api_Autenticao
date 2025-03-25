# ↪︎ Api Autenticação ↩︎

![csharp-image](https://img.shields.io/badge/csharp-^2022-blue)

## 📌 Funcionalidades

✅ Criação de usuário com armazenamento seguro da senha no banco de dados.  
✅ Login de usuário com autenticação via JWT.  
✅ Atualização de dados do usuário (em construção).  
✅ Exclusão de usuário (em construção).  
✅ Listar todos os usuarios cadastrados (em construção).


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

#### Cadastro de Usuário

```http
  POST /api/autenusuarios
```

| Parâmetro   | Tipo       | Descrição                           |
| :---------- | :--------- | :---------------------------------- |
| `nome` | `string` | **Obrigatório**. Nome do usuário |
| `email` | `string` | **Obrigatório**. Email do usuário |
| `senha` | `string` | **Obrigatório**. Senha do usuário |

#### Login de Usuário

```http
  POST /api/login
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `email`      | `string` | **Obrigatório**. Email do usuário |
| `senha`      | `string` | **Obrigatório**. Senha do usuário |

#### Atualização de Usuário - EM CONSTRUÇÃO

```http
  PUT /api/usuarios/:id
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `email`      | `string` | **Obrigatório**. Email do usuário |

#### Exclusão  de Usuário - EM CONSTRUÇÃO

```http
  DELETE /api/usuarios/:id
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `email`      | `string` | **Obrigatório**. Email do usuário |


#### Listar usuarios - EM CONSTRUÇÃO

```http
  GET /api/usuarios
```







