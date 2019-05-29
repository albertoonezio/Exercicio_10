using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Parte2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero = 0;
            int segundoNumero = 0;
            double dividirNumero = 0;

            Console.Write("Digite o Primeiro Número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (segundoNumero != 0)
            {
                dividirNumero = primeiroNumero % segundoNumero;
                Console.WriteLine("O Quociente do Primeiro para o Segundo Número é: {0}", dividirNumero);
            }

            else
            {
                Console.WriteLine("DIVISÃO POR ZERO");
            }
        }
    }
}
