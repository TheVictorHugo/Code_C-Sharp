using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entrar com as notas da PR1 e PR2 e imprimir a média final.
namespace exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR1, PR2 = 0;
            double media = 0;
            Console.Write("Digite a nota da prova 1:  ");
            PR1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da prova 2:  ");
            PR2 = double.Parse(Console.ReadLine());
            media = (PR1 + PR2) / 2;
            Console.WriteLine("A média do aluno é: {0}", media);
            Console.ReadLine();
        }
    }
}
