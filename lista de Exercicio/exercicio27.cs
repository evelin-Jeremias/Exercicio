﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio27
    {
           
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                }
                else
                {
                    Console.WriteLine(Convert.ToString(i) + " ");
                }
            }

            Console.ReadLine();
        }
    }
}