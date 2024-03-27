using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio21
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite o valor de B:");

            B = Convert.ToInt32(Console.ReadLine());

            if (A == 0)
            {
                C = A + B;


            }
            else
            {
                C = A * B;
            }

            Console.WriteLine("O resultado é:" + C);
        }
    }
}
