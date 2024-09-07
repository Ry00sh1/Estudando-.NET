using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste_Console.Common.Models
{
    public class Arrays
    {
        private string[] arr = new string[3];
        private int totalItensArr;

        public Arrays()
        {
            totalItensArr = arr.Length;

            arr[0] = "Pedro";
            arr[1] ="Ana";
            arr[2] ="Lucas";
            
        }

        public void ImprimeArrayDeNomes()
        {
            foreach (var item in arr)//itera sobre o array com foreach
            {
                Console.WriteLine(item);
            }

            for(int item = 0; item<arr.Length; item++)//itera sobre o array com um loop for
            {
                Console.WriteLine($"{item} = "+arr[item]);
            }
        }     

        //sobrescreve o método ToString para fornecer uma representação em string do array
        public override string ToString()
        {
            if (this.totalItensArr == 0)
            {
                return "[]";
            }

            StringBuilder builder = new StringBuilder();
            builder.Append("[");

            for (int i = 0; i < this.totalItensArr - 1; i++)
            {
                builder.Append(this.arr[i]);
                builder.Append(", ");
            }

            builder.Append(this.arr[this.totalItensArr - 1]);
            builder.Append("]");

            return builder.ToString();
        }

        //método para redimensionar o array
        public void RedimencionarArray()
        {
            Array.Resize(ref arr, arr.Length * 2);
        }  
    }

    public class Listas
        {
        private List<string> lista = new List<string>();

        public Listas()
        {                      
            lista.Add("Mariana");
            lista.Add("Carlos");
            lista.Add("Fernanda");
        }

        public void ImprimeListaDeNomes()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        //método para fornecer uma representação em string da lista
        public string ListaToString()
        {
            if (lista.Count == 0)
            {
                return "[]";
            }

            StringBuilder builder = new StringBuilder();
            builder.Append("[");

            for (int i = 0; i < lista.Count - 1; i++)
            {
                builder.Append(lista[i]);
                builder.Append(", ");
            }

            builder.Append(lista[lista.Count - 1]);
            builder.Append("]");

            return builder.ToString();
        }

        }
}