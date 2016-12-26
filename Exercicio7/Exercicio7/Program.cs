using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor, antecessor = 0;
            // recebe os dados
            Console.WriteLine("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());
            //processa
            sucessor = numero + 1;
            antecessor = numero - 1;
            //imprime
            Console.WriteLine("Sucessor do Número é: {0}", sucessor);
            Console.WriteLine("Antecessor do Númeos é: {0}", antecessor);
            Console.ReadLine();
        }
    }
}
