using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste_Console.Models
{
    public class EstruturasDeRepeticao
    {
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
    }
}