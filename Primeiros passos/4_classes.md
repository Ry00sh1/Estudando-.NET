# Classes

No .NET, uma **classe** é um dos blocos fundamentais de construção do código. Ela define um tipo de dado personalizado que pode conter **propriedades** (dados), **métodos** (comportamentos) e **eventos**. As classes são usadas para criar objetos, que são instâncias das classes, encapsulando dados e comportamentos relacionados.

## Código de Exemplo

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste_Console.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
```

## Estrutura de uma Classe

No exemplo acima, a classe `Pessoa` é definida dentro do namespace `ProjetoTeste_Console.Models`. Vamos detalhar seus componentes:

### 1. **Namespace**
   - O namespace `ProjetoTeste_Console.Models` organiza a classe `Pessoa` dentro de um agrupamento lógico. Isso ajuda a estruturar o código e a evitar conflitos de nomes com outras classes que podem existir em namespaces diferentes.

### 2. **Declaração da Classe**
   - A classe `Pessoa` é definida pela palavra-chave `public class Pessoa`.
   - A palavra-chave `public` torna a classe acessível a partir de outros códigos que utilizam esse namespace.

### 3. **Propriedades**
   - **`public string? Nome { get; set; }`**: Esta propriedade é do tipo `string` e pode armazenar o nome da pessoa. O `?` indica que essa propriedade pode ser `null`.
     - `get; set;` são os *accessors* que permitem ler (`get`) e atribuir valores (`set`) à propriedade.
   
   - **`public int Idade { get; set; }`**: Esta propriedade é do tipo `int` e armazena a idade da pessoa. Ela não pode ser nula.

### 4. **Método**
   - **`public void Apresentar()`**: Este é um método da classe. Um método define um comportamento que a classe pode realizar.
   - O método `Apresentar` escreve no console uma mensagem que inclui o nome e a idade da pessoa. Ele não retorna nenhum valor (por isso o tipo de retorno é `void`).

   ```csharp
   public void Apresentar()
   {
       Console.WriteLine($"Olá! Meu nome é {Nome} e tenho {Idade} anos");
   }
   ```

## Criando e Usando uma Instância de `Pessoa`

Para utilizar a classe `Pessoa`, você precisa criar uma instância (ou objeto) dela. Aqui está como você pode fazer isso:

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Criação de uma nova instância da classe Pessoa
        Pessoa pessoa = new Pessoa();

        // Definindo valores para as propriedades
        pessoa.Nome = "João";
        pessoa.Idade = 30;

        // Chamando o método Apresentar
        pessoa.Apresentar();
    }
}
```

Neste exemplo:

1. **`Pessoa pessoa = new Pessoa();`**: Isso cria um novo objeto `pessoa` da classe `Pessoa`.
2. **`pessoa.Nome = "João";`** e **`pessoa.Idade = 30;`**: Aqui, as propriedades `Nome` e `Idade` do objeto `pessoa` são definidas.
3. **`pessoa.Apresentar();`**: O método `Apresentar` é chamado, e ele executa a ação definida (neste caso, imprime uma mensagem no console).

### Resumo
- **Classe**: Um tipo de dado personalizado que define propriedades e métodos.
- **Propriedades**: Variáveis dentro da classe que armazenam dados.
- **Métodos**: Funções dentro da classe que definem comportamentos.
- **Instância (Objeto)**: Uma representação concreta de uma classe, criada para uso no código.

A classe `Pessoa` no exemplo acima encapsula as informações sobre uma pessoa (nome e idade) e define um comportamento (`Apresentar`) para exibir essas informações. Classes como essa são fundamentais para a programação orientada a objetos no .NET.