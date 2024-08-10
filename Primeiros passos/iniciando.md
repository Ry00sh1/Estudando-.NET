# Primeiros passos para iniciar um projeto .NET

# Na CLI do .NET

## 1. Instale o SDK do .NET

Antes de iniciar, certifique-se de que o SDK (Source Develpment Kit) do .NET está instalado na sua máquina. Você pode baixar a versão mais recente do SDK [aqui](https://dotnet.microsoft.com/download).

Para verificar se está instalado corretamente, abra o terminal ou prompt de comando e digite:

```bash
dotnet --version
```

Se o .NET estiver instalado, você verá a versão instalada.

## 2. Criando através da CLI do .NET

### 2.1 Criando um Novo Projeto

No terminal ou prompt de comando, navegue até o diretório onde deseja criar o novo projeto e use o seguinte comando para criar um novo projeto. Existem diferentes tipos de projetos que você pode criar. Aqui estão alguns exemplos:

#### 2.1.1 Criar um Aplicativo Console

Um aplicativo de console é um projeto básico que executa uma aplicação de linha de comando.

```bash
dotnet new console -n NomeDoProjeto
```

#### 2.1.2 Criar um Aplicativo Web (ASP.NET Core)

Se você está criando uma aplicação web, pode usar o seguinte comando:

```bash
dotnet new webapp -n NomeDoProjeto
```

#### 2.1.3 Criar uma API Web (ASP.NET Core)

Se estiver criando uma API RESTful, você pode usar o seguinte comando:

```bash
dotnet new webapi -n NomeDoProjeto
```

#### 2.1.4 Criar uma Biblioteca de Classes

Se precisar de uma biblioteca de classes para compartilhar código entre projetos:

```bash
dotnet new classlib -n NomeDoProjeto
```

### 2.2 Navegue até o Diretório do Projeto

Depois de criar o projeto, você pode navegar até o diretório do projeto:

```bash
cd NomeDoProjeto
```

### 2.3 Executar o Projeto

Para garantir que o projeto foi criado corretamente e está funcionando, você pode executar o projeto usando:

```bash
dotnet run
```

### 2.4 Abrir o Projeto em um Editor de Código

Se você estiver usando um editor de código como o Visual Studio Code, pode abrir o projeto diretamente no editor:

```bash
code .
```


## 3. Criando um projeto no VSCode

### 3.1 Acesse a paleta de comandos
No VSCode, acesse a Paleta de Comandos (Crtl + Shift + P)

### 3.2 Encontre a opção necessária
Busque o seguinte termo:
```
.NET: Novo projeto
```
Após encontrá-lo, clique na opção.

### 3.3 Escolha o projeto que deseja criar
O sistema irá mostrar vários tipos de projetos possíveis, escolha o tipo que você deseja criar.

### 3.4 Escolhendo um nome
O sistema irá solicitar um nome para o projeto. De preferência, escolha um nome que tenha a ver com as caracteríscas ou objetivos do projeto.

### 3.5 Local do projeto
- **Caso você já esteja com um local aberto no Explorador do VSCode:** o sistema irá solicitar a confirmação se você deseja armazenar no local selecionado.<br>
- **Caso você não esteja com uma pasta aberta no Explorador do VSCode:** o sistema irá abrir o explorador do para que você escolha aonde o projeto ficará armazenado.

### 3.6 Confirme
Confirme a criação do projeto. Você verá que o VSCode já irá abrir a pasta do projeto na aba do Explorador.

# Outros comandos no CLI

## 1. Gerenciar Dependências e Pacotes

Para adicionar pacotes ou dependências ao seu projeto, você pode usar o comando `dotnet add package`:

```bash
dotnet add package NomeDoPacote
```

### 2. Compilar e Executar

Se você quiser apenas compilar o projeto sem executá-lo, use:

```bash
dotnet build
```

Para executar testes (se houver testes configurados):

```bash
dotnet test
```

## 3. Publicar o Projeto

Para publicar o projeto (gerar uma versão que pode ser distribuída e executada):

```bash
dotnet publish -c Release
```

Este comando cria uma versão de produção da sua aplicação no modo "Release".