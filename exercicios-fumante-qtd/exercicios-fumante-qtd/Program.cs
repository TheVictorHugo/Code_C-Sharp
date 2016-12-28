using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Calcular a quantidade de dinheiro gasta por um fumante. Dados: o número de 
//anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
namespace exercicios_fumante_qtd
{
    class Program
    {
        static void Main(string[] args)
        {
            double anos, qtddia, custos, resposta = 0;

            Console.Write("Digiste quantos anos de fumante: ");
            anos = double.Parse(Console.ReadLine());
            Console.Write("Digite quantos cigarros fumados por dia: ");
            qtddia = double.Parse(Console.ReadLine());
            Console.Write("Quanto custa a carteira de cigarro: ");
            custos = double.Parse(Console.ReadLine());

            resposta = anos * qtddia * custos;

            Console.WriteLine("O gasto por esses anos fois:  {0}", resposta);
            Console.ReadLine();

        }
    }
}
