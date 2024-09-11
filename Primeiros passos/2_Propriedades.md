No .NET, **propriedades** são membros de classes, structs ou interfaces que fornecem um mecanismo flexível para ler, escrever ou computar valores de campos particulares. As propriedades são usadas para encapsular dados e fornecer acesso controlado a esses dados, permitindo que você aplique lógica adicional ao recuperar ou definir valores.

## Estrutura de Propriedades

Uma propriedade é definida usando uma combinação de métodos `get` e `set`, que são chamados de acessadores. O acessador `get` é usado para retornar o valor da propriedade, enquanto o acessador `set` é usado para atribuir um novo valor.

Aqui está um exemplo básico de uma propriedade em C#:

```csharp
public class Pessoa
{
    private string nome;

    // Propriedade Nome com acessadores get e set
    public string Nome
    {
        get
        {
            return nome;
        }
        set
        {
            // Opcional: Lógica adicional para validação
            if (!string.IsNullOrWhiteSpace(value))
            {
                nome = value;
            }
        }
    }
}
```

Neste exemplo, a propriedade `Nome` controla o acesso ao campo privado `nome`. Quando a propriedade é lida, o acessador `get` é executado, retornando o valor do campo. Quando a propriedade é definida, o acessador `set` é executado, permitindo que você adicione lógica (como validação) antes de alterar o valor do campo.

## Tipos de Propriedades

1. **Propriedades Automáticas**:
   - Para conveniência, você pode usar propriedades automáticas, onde o compilador cria automaticamente um campo privado para armazenar o valor da propriedade. Isso simplifica a sintaxe quando nenhuma lógica adicional é necessária.

   ```csharp
   public class Carro
   {
       // Propriedade automática
       public string Modelo { get; set; }
   }
   ```

   Neste exemplo, a propriedade `Modelo` é uma propriedade automática sem um campo explícito. O compilador cria um campo privado automaticamente.

2. **Propriedades Somente Leitura**:
   - Se você quiser criar uma propriedade que só pode ser lida e não modificada após a inicialização, você pode omitir o acessador `set`.

   ```csharp
   public class Circulo
   {
       public double Raio { get; }

       public Circulo(double raio)
       {
           Raio = raio; // Propriedade é atribuída no construtor
       }
   }
   ```

   Aqui, a propriedade `Raio` é definida apenas no construtor e não pode ser alterada depois.

3. **Propriedades Somente Gravação**:
   - Embora menos comum, você pode criar uma propriedade que só pode ser escrita, omitindo o acessador `get`.

   ```csharp
   public class Log
   {
       private string mensagem;

       // Propriedade de gravação
       public string Mensagem
       {
           set
           {
               mensagem = value;
               // Lógica adicional, como registrar a mensagem
           }
       }
   }
   ```

   Aqui, a propriedade `Mensagem` pode ser definida, mas não lida diretamente.

4. **Propriedades Computadas**:
   - Propriedades podem ser usadas para calcular valores com base em outros campos ou propriedades.

   ```csharp
   public class Retangulo
   {
       public double Largura { get; set; }
       public double Altura { get; set; }

       // Propriedade calculada
       public double Area
       {
           get
           {
               return Largura * Altura;
           }
       }
   }
   ```

   A propriedade `Area` não armazena diretamente um valor, mas calcula e retorna o valor com base nas propriedades `Largura` e `Altura`.

## Expressões Lambda em Propriedades

Propriedades podem usar expressões lambda para simplificar a definição de acessadores `get` e `set`, especialmente em casos simples.

```csharp
public class Quadrado
{
    public double Lado { get; set; }

    // Propriedade com expressão lambda
    public double Area => Lado * Lado;
}
```

Nesse exemplo, a propriedade `Area` é definida usando uma expressão lambda, tornando o código mais conciso.

## Benefícios das Propriedades:

- **Encapsulamento**: Permitem o controle sobre como um campo é acessado ou modificado.
- **Validação**: Pode-se incluir lógica de validação ou manipulação de dados dentro dos acessadores.
- **Modificação sem Quebra de Código**: A implementação interna de uma propriedade pode mudar sem afetar o código que usa a propriedade, desde que a interface (a assinatura da propriedade) permaneça a mesma.