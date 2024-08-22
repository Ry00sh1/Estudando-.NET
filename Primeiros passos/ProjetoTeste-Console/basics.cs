using ProjetoTeste_Console.Models;
using System;

Console.WriteLine("/*Estruturas de Repetição*/");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n");

int j = 1;
while (j <= 5)
{
    Console.WriteLine(j);
    j++; // Incrementa a variável de controle
}
Console.WriteLine("\n");

// Imprime números de 1 a 5
do
{
    Console.WriteLine(j);
    j++; // Incrementa a variável de controle
} while (j <= 5);

Console.WriteLine("\n");
int[] numeros = { 1, 2, 3, 4, 5 };

// Imprime todos os números no array
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
Console.WriteLine("\n");

Console.WriteLine("/*Biblioteca Math*/");

double num = -5.5;

double absoluteValue = Math.Abs(num); // Valor absoluto
double power = Math.Pow(2, 3); // Potência
double squareRoot = Math.Sqrt(16); // Raiz quadrada

Console.WriteLine($"Valor absoluto de {num}: {absoluteValue}");
Console.WriteLine($"2 elevado a 3: {power}");
Console.WriteLine($"Raiz quadrada de 16: {squareRoot}");

Console.WriteLine("\n");
Console.WriteLine("/*Operadores lógicos*/");
int number = 10;

// Verifica se o número está entre 1 e 20 e se é par
if ((number > 1 && number < 20) && (number % 2 == 0))
{
    Console.WriteLine($"{number} está entre 1 e 20 e é um número par.");
}
else
{
    Console.WriteLine($"{number} não está entre 1 e 20 ou não é um número par.");
}
Console.WriteLine("\n");
// Verifica se o número é menor que 1 ou maior que 100
if (number < 1 || number > 100)
{
    Console.WriteLine($"{number} está fora do intervalo de 1 a 100.");
}
else
{
    Console.WriteLine($"{number} está dentro do intervalo de 1 a 100.");
}

Console.WriteLine("/*Estrutura condicional. Leitura de dados tipo int.*/");
int day = 4;

Console.Write("Dia da semana = ");
switch (day) 
{
  case 1:
    Console.WriteLine("Segunda-feira");
    break;
  case 2:
    Console.WriteLine("Terça-feira");
    break;
  case 3:
    Console.WriteLine("Quarta-Feira");
    break;
  case 4:
    Console.WriteLine("Quinta-feira");
    break;
  case 5:
    Console.WriteLine("Sexta-feira");
    break;
  case 6:
    Console.WriteLine("Sábado");
    break;
  case 7:
    Console.WriteLine("Domingo");
    break;
}
Console.WriteLine("\n");

Console.WriteLine("Qual a quantidade do item em estoque?");
int quantidadeEmEstoque = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual foi a quantidade comprada?");
int quantidadeComprada = Convert.ToInt32(Console.ReadLine());

bool possibilidadeVenda = quantidadeComprada <= quantidadeEmEstoque;
Console.WriteLine($"É possível realizar a venda? {possibilidadeVenda}");

if (quantidadeComprada <= quantidadeEmEstoque)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine($"Venda não realizada. Quantidade solicitada '{quantidadeComprada}' excede a quantidade em estoque '{quantidadeEmEstoque}'");
}



Console.WriteLine("/*Utilizando a classe Pessoa*/");


Pessoa pessoa1 = new Pessoa();
    
pessoa1.Nome = "Pedro";
pessoa1.Idade = 24;

pessoa1.Apresentar();