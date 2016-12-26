using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Digite um números: ");
            //pega o valor digitado que é string
            //depois converte para inteiro (int)
            numero = int.Parse(Console.ReadLine());
            //imprime na tela
            Console.WriteLine("Você digitou: {0}", numero);
            Console.ReadLine();

        }
    }
}
