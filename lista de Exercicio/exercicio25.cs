﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio25
    {
        static void Main(string[] args)
        {
            int a, fatorial = 1;

            Console.Write("Digite um valor para A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(a + "! = ");

            for (int i = a; i >= 1; i--)
            {
                Console.Write(i + " ");
                fatorial *= i;

                if (i > 1)
                {
                    Console.Write("X ");
                }
            }

            Console.Write("= " + fatorial);

            Console.ReadLine();
        }
    }
}