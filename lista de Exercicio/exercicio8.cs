﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio8
    {
        static void Main(string[] args)
        {
            double raio, volume;

            Console.WriteLine("Digite o raio da esfera:");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é: + volume");

            Console.ReadLine();
        }
    }
}
