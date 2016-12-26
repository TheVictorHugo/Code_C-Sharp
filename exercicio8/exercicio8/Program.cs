using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ler nome, endereço e telefone e imprimi-los.

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone = "";

            Console.Write("Digite seu nome:  ");
            nome = Console.ReadLine();
            Console.Write("Digite seu endereco:  ");
            endereco = Console.ReadLine();
            Console.Write("Digite seu telefone:  ");
            telefone = Console.ReadLine();

            Console.WriteLine("Seu Nome é: {0}, e você mora em : {1}, com o telefone: {2}", nome, endereco, telefone);
            Console.ReadLine();
        }
    }
}
