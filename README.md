# ControleDeMedicamentos

Sistema de controle de medicamentos desenvolvido em C#, com arquitetura dividida em camadas (Domínio, Infraestrutura, projeto SQL), que permite gerenciar cadastros, armazenamento e persistência dos dados via arquivos ou banco SQL Server.

---

## Índice

- [Descrição](#descrição)  
- [Funcionalidades](#funcionalidades)  
- [Arquitetura/Organização do Projeto](#arquiteturaorganização-do-projeto)  
- [Requisitos](#requisitos)  
- [Instalação](#instalação)  
- [Uso](#uso)  
- [Configuração do Banco de Dados](#configuração-do-banco-de-dados)  
- [Contribuição](#contribuição)  
- [Tecnologias Utilizadas](#tecnologias-utilizadas)

---

## Descrição

O **ControleDeMedicamentos** é um sistema que permite controlar medicamentos, registrando informações básicas (nome, validade, lote, etc), possibilitando armazenar dados via arquivos ou via banco de dados SQL Server. Ideal para uso em clínicas ou farmácias de pequeno porte ou como aplicação de aprendizado de boas práticas em desenvolvimento.

---

## Funcionalidades

- Cadastro de medicamentos (nome, data de validade, lote, quantidade, etc).  
- Persistência de dados via **Arquivos** ou **SQL Server**.  
- Organização modular por camadas (Domínio, Infraestrutura, Utilitários).  
- Possibilidade de registrar logs ou relatórios (se aplicável).  
- Fácil manutenção e extensão.

---

## Arquitetura / Organização do Projeto

O repositório está organizado da seguinte forma:

| Pasta / Projeto | Descrição |
|---|---|
| `ControleDeMedicamentos.Dominio` | Contém as entidades do domínio, regras de negócio, modelos. |
| `ControleDeMedicamentos.Infraestrutura.Arquivos` | Implementação de persistência via arquivos. |
| `ControleDeMedicamentos.Infraestrutura.SqlServer` | Implementação de persistência via SQL Server. |
| `ControleDeMedicamentos.Util.SqlProject` | Scripts SQL / utilitários para banco de dados. |
| `ControleDeMedicamentos` | Camada de apresentação / interface (console, GUI, API – depende da implementação) |
| `.vscode` | Configurações para desenvolvimento no VSCode. |
| `ControleDeMedicamentos.sln` | Solução principal do Visual Studio. |

---

## Requisitos

- .NET SDK (versão compatível – sugerido .NET 6 ou superior)  
- SQL Server (se for usar a persistência com banco de dados)  
- Permissões de leitura/gravação em disco (se usar a opção de arquivos)  
- Ambiente Windows (idealmente) ou compatível com .NET/.NET Core

---

## Instalação

1. Clone o repositório:  
   ```bash
   git clone https://github.com/marcelopaes26/ControleDeMedicamentos.git
   ```

2. Abra a solução no Visual Studio ou VSCode.

3. Restaure os pacotes NuGet:  
   ```bash
   dotnet restore
   ```

4. Se estiver usando o SQL Server, configure o banco de dados (ver próximo tópico).

---

## Uso

1. Compile e execute o projeto principal (`ControleDeMedicamentos`) via IDE ou CLI:  
   ```bash
   dotnet run --project ControleDeMedicamentos
   ```

2. Escolha o modo de persistência desejado: via arquivos ou SQL Server.

3. Para arquivos, certifique-se de que há diretório configurado para salvar os dados.

4. Para SQL Server: insira a string de conexão correta no arquivo de configuração.

---

## Configuração do Banco de Dados

- No projeto `ControleDeMedicamentos.Util.SqlProject` há scripts SQL para criar as tabelas necessárias.  
- Execute os scripts no SQL Server para criar o banco ou usar um já existente.  
- Atualize a *connection string* no projeto `ControleDeMedicamentos.Infraestrutura.SqlServer` com os parâmetros corretos (servidor, banco, usuário, senha).

Exemplo de *connection string*:

```json
"ConnectionStrings": {
  "MedicamentosDB": "Server=SEU_SERVIDOR;Database=ControleDeMedicamentosDb;User Id=usuario;Password=senha;"
}
```

---

## Como contribuir

Contribuições são bem-vindas! Algumas diretrizes:

1. Abra uma _issue_ para discutir o que você gostaria de mudar.  
2. Faça um _fork_ do projeto.  
3. Crie uma nova branch para sua feature ou correção:  
   ```bash
   git checkout -b minha-melhoria
   ```
4. Faça suas alterações, teste, documente.  
5. Envie um Pull Request com uma descrição clara do que foi alterado.

---

## Tecnologias Utilizadas
[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,sqlite,git,github,vscode)](https://skillicons.dev)
