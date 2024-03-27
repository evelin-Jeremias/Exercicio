using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio17
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite tres valores inteiros e diferentes: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + ", " + b + ", " + c);
                }
                else
                {
                    Console.WriteLine(a + ", " + c + ", " + b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                else
                {
                    Console.WriteLine(b + ", " + c + ", " + a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(c + ", " + a + ", " + b);
                }
                else
                {
                    Console.WriteLine(c + ", " + b + ", " + a);
                }
            }

            Console.ReadLine();
        }
    }
}