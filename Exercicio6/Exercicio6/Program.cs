using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler dois números inteiros e imprimi-los.
namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            //Solicita o primeiro números
            // depois converte (string/int) e
            //armazena na variavel n1
            Console.WriteLine("Digite o 1º Número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º Número: ");
            n2 = int.Parse(Console.ReadLine());

            //imprime os números
            Console.WriteLine("Você digitou: {0} e {1}", n1, n2);
            Console.ReadLine();
        }
    }
}
