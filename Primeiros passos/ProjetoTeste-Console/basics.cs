using ProjetoTeste_Console.Models;
using System;



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




Console.WriteLine("/*Utilizando a classe Pessoa*/");


Pessoa pessoa1 = new Pessoa();
    
pessoa1.Nome = "Pedro";
pessoa1.Idade = 24;

pessoa1.Apresentar();
