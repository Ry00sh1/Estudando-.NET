using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste_Console.Common.Models
{
    public class EstruturasCondicionais
    {
        void IfClass(int numero){
            // Verifica se o número inteiro fornecido é par ou impar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par.");
                return;
            }
            else
            {
                Console.WriteLine($"{numero} é impar.");
                return;
            }
            
        }

        void ElseIfClass(double nota){
            // Verifica se aluno foi aprovado, reprovado ou fará prova de recuperação
            if (nota >= 70)
            {
                Console.WriteLine("Aluno aprovado!");
                return;
            }
            else if(nota >= 50)
            {
                Console.WriteLine("Aluno fará prova de recuperação!");
                return;
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
                return;
            }
            
        }


        void SwitchClass(int dia){
            //Recebe um número inteiro enre 1 a 7 e retorna o dia da semana referente a esse número
            Console.Write("Dia da semana = ");
            if(dia >=1 && dia<=7)
            {
                switch (dia) 
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
            }
        }
    }
}