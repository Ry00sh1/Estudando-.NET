# Estrutura de um Projeto - Console

Um projeto de console no .NET é uma aplicação que roda em um terminal ou linha de comando, executada diretamente no sistema operacional. A estrutura básica de um projeto de console inclui os seguintes elementos:

## 1. **Arquivos Principais**
- **Program.cs (ou Program.vb para Visual Basic)**: Contém o método `Main`, que é o ponto de entrada da aplicação. O método `Main` é chamado pelo runtime do .NET para iniciar a execução do programa.

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

- **Arquivo de Projeto (.csproj ou .vbproj)**: Um arquivo XML que define configurações do projeto, como o SDK utilizado, as dependências externas (pacotes NuGet), e configurações de build.

   ```xml
   <Project Sdk="Microsoft.NET.Sdk">
     <PropertyGroup>
       <OutputType>Exe</OutputType>
       <TargetFramework>net7.0</TargetFramework>
     </PropertyGroup>
   </Project>
   ```

## 2. **Estrutura de Pastas**
- **/bin/**: Diretório onde os arquivos compilados (executáveis e DLLs) são gerados.
  - **/Debug/**: Saída de build em modo Debug, que inclui símbolos de depuração.
  - **/Release/**: Saída de build em modo Release, otimizada para produção.

- **/obj/**: Diretório de arquivos temporários gerados durante a compilação.

- **/Properties/**: Pode conter arquivos de configuração adicionais, como `launchSettings.json`, que define configurações de execução e depuração.

## 3. **Pacotes e Dependências**
- Dependências externas são gerenciadas através do NuGet. Elas são listadas no arquivo `.csproj` e podem ser restauradas com `dotnet restore`.

---

# Estrutura de um Projeto - Frontend (ASP.NET MVC)

Um projeto Frontend com ASP.NET MVC segue o padrão Model-View-Controller, separando a interface do usuário, a lógica de negócios e o acesso a dados.

## 1. **Arquivos Principais**
- **Startup.cs**: Configura a aplicação, incluindo serviços e o pipeline de middleware.

   ```csharp
   public class Startup
   {
       public void ConfigureServices(IServiceCollection services)
       {
           services.AddControllersWithViews();
       }

       public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
       {
           if (env.IsDevelopment())
           {
               app.UseDeveloperExceptionPage();
           }
           else
           {
               app.UseExceptionHandler("/Home/Error");
               app.UseHsts();
           }

           app.UseHttpsRedirection();
           app.UseStaticFiles();
           app.UseRouting();
           app.UseAuthorization();
           app.UseEndpoints(endpoints =>
           {
               endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
           });
       }
   }
   ```

- **Program.cs**: Define o ponto de entrada da aplicação e inicializa o host web.

## 2. **Estrutura de Pastas**
- **/Controllers/**: Contém os controladores que gerenciam requisições do usuário.
- **/Views/**: Contém as páginas HTML renderizadas para o usuário.
- **/Models/**: Contém os modelos de dados manipulados pela aplicação.

## 3. **Pacotes e Dependências**
- Gerenciadas via NuGet, como `Microsoft.AspNetCore.Mvc`.

---

# Estrutura de um Projeto - Backend (ASP.NET Core API)

Um projeto Backend com ASP.NET Core API é usado para criar serviços web RESTful.

## 1. **Arquivos Principais**
- **Startup.cs**: Configura serviços da aplicação e o pipeline de middleware, focado em serviços de API.

   ```csharp
   public class Startup
   {
       public void ConfigureServices(IServiceCollection services)
       {
           services.AddControllers();
       }

       public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
       {
           if (env.IsDevelopment())
           {
               app.UseDeveloperExceptionPage();
           }

           app.UseRouting();
           app.UseEndpoints(endpoints =>
           {
               endpoints.MapControllers();
           });
       }
   }
   ```

- **Program.cs**: Inicializa a aplicação e o host.

## 2. **Estrutura de Pastas**
- **/Controllers/**: Contém os controladores de API.
- **/Models/**: Define classes de modelo para os dados manipulados pela API.
- **/Services/**: (Opcional) Contém lógica de negócio e serviços.

## 3. **Pacotes e Dependências**
- Dependências comuns incluem `Microsoft.AspNetCore.Mvc` e `Swashbuckle.AspNetCore` (para documentação Swagger).

---

# Estrutura de um Projeto - Desktop (WPF ou Windows Forms)

Um projeto Desktop no .NET, utilizando WPF ou Windows Forms, cria aplicações GUI que rodam no Windows.

## 1. **Arquivos Principais**
- **MainWindow.xaml**: Define a interface do usuário com XAML.

   ```xml
   <Window x:Class="ProjetoDesktop.MainWindow"
           xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
           xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
           Title="MainWindow" Height="350" Width="525">
       <Grid>
           <Button Content="Clique Aqui" HorizontalAlignment="Left" VerticalAlignment="Top"/>
       </Grid>
   </Window>
   ```

- **MainWindow.xaml.cs**: Código-behind para o arquivo XAML.

   ```csharp
   public partial class MainWindow : Window
   {
       public MainWindow()
       {
           InitializeComponent();
       }
   }
   ```

## 2. **Estrutura de Pastas**
- **/Views/**: Contém os arquivos XAML e seus códigos-behind.
- **/ViewModels/**: Contém os ViewModels (para o padrão MVVM).

## 3. **Pacotes e Dependências**
- Dependências como `System.Windows.Forms` (Windows Forms) ou `Microsoft.NET.Sdk.WindowsDesktop` (WPF).

---

# Estrutura de um Projeto - Mobile (MAUI)

Um projeto Mobile no .NET usando .NET MAUI permite criar aplicativos para iOS, Android, Windows e Mac.

## 1. **Arquivos Principais**
- **MainPage.xaml**: Define a interface do usuário.

   ```xml
   <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="ProjetoMobile.MainPage">
       <StackLayout>
           <Label Text="Bem-vindo ao .NET MAUI!"
                  VerticalOptions="CenterAndExpand" 
                  HorizontalOptions="CenterAndExpand" />
           <Button Text="Clique Aqui" />
       </StackLayout>
   </ContentPage>
   ```

- **MainPage.xaml.cs**: Código-behind da página principal.

   ```csharp
   public partial class MainPage : ContentPage
   {
       public MainPage()
       {
           InitializeComponent();
       }
   }
   ```

## 2. **Estrutura de Pastas**
- **/Views/**: Contém as páginas do aplicativo.
- **/ViewModels/**: Implementa a lógica da interface (MVVM).
- **/Models/**: Define classes de dados.

## 3. **Pacotes e Dependências**
- Dependências incluem `Microsoft.Maui.Controls`.

---

# Para Que Serve o Arquivo `.sln`?

O arquivo `.sln` (abreviação de *solution*) é usado em projetos .NET para:

1. **Gerenciar Múltiplos Projetos**: Agrupa vários projetos relacionados em uma única solução.
2. **Configurações de Build e Debug**: Armazena configurações como perfis de build, configurações de compilação e variáveis de ambiente.
3. **Organização no Visual Studio**: Indica ao Visual Studio como carregar e exibir os projetos.

## Tipos de Projeto que Usam o `.sln`
Projetos como:
- Aplicativos Web (ASP.NET, ASP.NET Core)
- Aplicativos Desktop (Windows Forms, WPF)
- Aplicativos Móveis (Xamarin)
- APIs e Serviços Web (Web APIs, gRPC)
- Bibliotecas de Classes, Aplicações de Console, Testes Unitários, Projetos de Containers/Docker

## Estrutura de um Arquivo `.sln`

Um arquivo `.sln` é um texto com informações organizadas em seções.

## Exemplo de Estrutura de um Arquivo `.sln`

```plaintext
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.0.31903.59
MinimumVisualStudioVersion = 10.0.40219.1

Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "MyProject", "MyProject\MyProject.csproj", "{A0D2B400-3124-44F9-8E9F-4D1F6BC3E945}"
EndProject
Project("{

FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "MyLibrary", "MyLibrary\MyLibrary.csproj", "{A47F67A6-7C4E-4BA9-9D13-35E0BF93EAC5}"
EndProject

Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{A0D2B400-3124-44F9-8E9F-4D1F6BC3E945}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{A0D2B400-3124-44F9-8E9F-4D1F6BC3E945}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{A0D2B400-3124-44F9-8E9F-4D1F6BC3E945}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{A0D2B400-3124-44F9-8E9F-4D1F6BC3E945}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
EndGlobal
```