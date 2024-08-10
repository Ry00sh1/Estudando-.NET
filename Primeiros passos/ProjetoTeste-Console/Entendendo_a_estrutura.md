# Estrutura de um projeto - Console

Um projeto de console no .NET é uma aplicação simples que roda em uma janela de console (linha de comando) e é executada diretamente no sistema operacional. A estrutura básica de um projeto de console no .NET inclui os seguintes elementos:

### 1. **Arquivos Principais**
   - **Program.cs (ou Program.vb em Visual Basic)**: Este é o ponto de entrada principal do programa. O arquivo contém o método `Main`, que é o método inicial que o .NET runtime chama para iniciar a execução do programa.
   
   ```csharp
   using System;

   namespace MyConsoleApp
   {
       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hello, World!");
           }
       }
   }
   ```

   - **.csproj (ou .vbproj)**: Este arquivo define o projeto e suas dependências. É um arquivo XML que especifica as configurações do projeto, como o SDK do .NET utilizado, as dependências externas (pacotes NuGet), configurações de build, etc.

   ```xml
   <Project Sdk="Microsoft.NET.Sdk">

     <PropertyGroup>
       <OutputType>Exe</OutputType>
       <TargetFramework>net7.0</TargetFramework>
     </PropertyGroup>

   </Project>
   ```

### 2. **Estrutura de Pastas**
   - **/bin/**: Diretório onde os arquivos compilados (executáveis e dlls) são gerados. Este diretório é criado após a compilação do projeto.
     - **/Debug/**: Contém a saída de build em modo Debug, que inclui símbolos de depuração.
     - **/Release/**: Contém a saída de build em modo Release, otimizada para produção.

   - **/obj/**: Diretório de arquivos temporários gerados durante a compilação, como intermediários de compilação, cache e outras informações.

   - **/Properties/**: Pode conter arquivos de configuração adicionais do projeto, como `launchSettings.json` que define configurações de execução e depuração do projeto.

### 3. **Pacotes e Dependências**
   - Dependências externas são gerenciadas através do sistema NuGet. As referências aos pacotes NuGet são adicionadas ao arquivo `.csproj` e podem ser restauradas usando o comando `dotnet restore`.

### 4. **Comandos Básicos**
   - **Criar um novo projeto**: `dotnet new console -n MyConsoleApp`
   - **Restaurar dependências**: `dotnet restore`
   - **Compilar o projeto**: `dotnet build`
   - **Executar o projeto**: `dotnet run`
   - **Adicionar um pacote NuGet**: `dotnet add package <PackageName>`

### 5. **Configurações Adicionais**
   - **launchSettings.json** (em `/Properties`): Este arquivo define as configurações de inicialização para diferentes ambientes de execução (como IIS para aplicações web). Em um projeto de console, ele é mais comumente utilizado para definir variáveis de ambiente e argumentos de linha de comando para diferentes perfis de execução.

### 6. **Entrada e Saída**
   - **Entrada (Input)**: Pode ser capturada usando `Console.ReadLine()`.
   - **Saída (Output)**: Pode ser enviada ao console usando `Console.WriteLine()`.

Essa estrutura é bastante simples, o que torna os projetos de console no .NET ideais para tarefas automatizadas, ferramentas de linha de comando, protótipos rápidos e aprendizado de programação.