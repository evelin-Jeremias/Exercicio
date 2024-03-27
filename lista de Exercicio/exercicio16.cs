using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio16
    {
        static void Main(string[] args)
        {
            const decimal valorAumento = 0.15m;
            const decimal impostos = 0.8m;

            decimal salarioAtual, salarioComAumento, salarioFinal;

            Console.Write("Digite o seu salário atual: ");
            salarioAtual = Convert.ToDecimal(Console.ReadLine());

            salarioComAumento = salarioAtual + salarioAtual * valorAumento;

            salarioFinal = salarioComAumento - salarioComAumento * impostos;

            Console.WriteLine("\nO salário com aumento é: " + salarioComAumento);
            Console.WriteLine("O salário final é: " + salarioFinal);
        }
    }
}
