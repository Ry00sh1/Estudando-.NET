using ProjetoTeste_Console.Common.Models;

namespace Main
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("----------MENU----------");


            Pessoa p = new Pessoa();

            Console.Write("Vamos definir um Nome: ");
            String? nome = Console.ReadLine();
            p.Nome = nome;

            Console.Write("Vamos definir a Data de Nascimento. \nDigite o Dia:");
            int dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Mês:");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Ano:");
            int ano = Convert.ToInt32(Console.ReadLine());
            p.DTN.DefineDataDeNascimento(dia,mes,ano);
            
            p.Apresentar();

        }
    }
}
