using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste_Console.Common.Models
{
    public class EstruturasDeRepeticao
    {
        public void LoopFor(int n) //imprime números de 1 a n
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
       
        }
        public void LoopWhile() //usuário deve descobrir um número aleatório enre 1 e 100
        {
            Random random = new Random();
            int i = random.Next(101);
            Console.WriteLine("Descubra o número de 1 a 100: ");
            int n = Convert.ToInt32((Console.ReadLine()));

            while (i != n)
            {
                Console.WriteLine("Errou! Tente novamente!");
                n = Convert.ToInt32((Console.ReadLine()));
            }
            Console.WriteLine($"Correto! O número era {i}!");
        }
        

        
        public void LoopDoWhile(int n) //imprime números de n a 1
        {   
            do
            {
                Console.WriteLine(n);
                n--;
            } while (n != 1);
        }
        public void LoopForeach(Array n)//imprime todos os números no array fornecido 
        {
            foreach (int numero in n)
            {
                Console.WriteLine(numero);
            }
        }

        
        
    }
}