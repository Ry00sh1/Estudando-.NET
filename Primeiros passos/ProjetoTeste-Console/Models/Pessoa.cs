using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net;

namespace ProjetoTeste_Console.Models
{
    public class Pessoa
    {
        public EstruturaDataDeNascimento DTN = new EstruturaDataDeNascimento();
        public string? Nome { get; set; }

        public void Apresentar()
        {
            int idade = DTN.CalculaIdade();
            string dataFormatada = DTN.Data.ToString("dd/MM/yyyy"); //formatando a estrutura DateTime para exibir apenas a data
            Console.WriteLine($"Olá! Meu nome é {Nome}, nasci em {dataFormatada} e tenho {idade} anos!");
        }
    }

    public class EstruturaDataDeNascimento
    {
        public DateTime Data { get; set; } //criando um atributo Data do tipo DateTime
        public DateTime DefineDataDeNascimento(int dia, int mes, int ano) //método usado para definir a data de nascimento
        {
            Data = new DateTime(ano, mes, dia);
            return Data;
        }
        
        
        public int CalculaIdade() //método que calcula a idade subtraindo a data de nascimento pela data atual
        {
            DateTime hoje = DateTime.Now;
            int idade = hoje.Year - Data.Year;

            if (hoje < Data.AddYears(idade)) //caso a data fornecida ainda irá chegar, ou seja, ainda não houve aniversário, a condição retorna a idade-1
            {
                idade--;
            }

            return idade;
        }

    }
}
