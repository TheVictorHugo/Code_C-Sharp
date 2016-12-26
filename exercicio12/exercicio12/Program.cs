using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Entrar com dois números reais e imprimir a média aritmética com a mensagem “Média” antes do resultado.
namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2 = 0;
            double resultado = 0;
            Console.Write("Digite o Primeiro Número:  ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Seguendo Número:  ");
            n2 = double.Parse(Console.ReadLine());
            resultado = (n1 + n2) / 2;
            Console.WriteLine("A Média é {0}", resultado);
            Console.ReadLine();

        }
    }
}
