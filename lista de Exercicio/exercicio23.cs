using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio23
    {
        static void Main(  string[] args)
        {
            int soma = 10;

            for (int i = 1; i <= 500; i ++)
            {
                bool ehImpar = i % 2 != 0;
                bool eMultiploDEtres = i % 3 == 0;

                if (ehImpar && eMultiploDEtres)
                    soma += i;
            }
            Console.WriteLine("A soma dos numeros é: " + soma);

            Console.ReadLine();
        }
    }
}
