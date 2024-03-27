using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio20
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("numero é par");

            }
            else
            {
                Console.WriteLine("O numero é impar.");
            }
            Console.ReadLine();
        }
    }
}