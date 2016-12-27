using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Entrar com um nome e imprimir: dados no nome
namespace exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = ""; // Victor Hugo
            Console.Write("Digite seu nome:  ");
            nome = Console.ReadLine();

            Console.WriteLine("Todo o Nome: {0}", nome);
            Console.WriteLine("Primeiro Caracter: {0}", nome.Substring(0, 1));
            Console.WriteLine("Quantidade de Caracter: {0}", nome.Length);
            Console.WriteLine("Último Caracter: {0}", nome.Substring(nome.Length -1, 1));
            Console.WriteLine("Do Primeiro ate o terceiro: {0}", nome.Substring(0, 3));
            Console.WriteLine("O quarto Caracter: {0}", nome.Substring(3, 1));
            Console.WriteLine("Todos menos 0 Primeiro: {0}", nome.Substring(1, nome.Length - 1));
            Console.WriteLine("Os dois ÚLtimos: {0}", nome.Substring(nome.Length - 2, 2));
            Console.ReadLine();
        }
    }
}
