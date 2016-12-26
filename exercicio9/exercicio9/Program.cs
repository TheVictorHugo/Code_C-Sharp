using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler dois números inteiros e imprimir a soma. Antes do resultado, deverá aparecer a mensagem: Soma
namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;
            int resultado = 0;
            Console.Write("Digite o Primeiro Números: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo Número:  ");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("A soma é {0}", resultado);
            Console.ReadLine();
        }
    }
}
