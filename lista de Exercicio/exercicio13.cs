using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio13
    {
        static void Main(string[] args)
        {
            Console.Clear();

            const decimal PrecoDoPao = 0.12m;
            const decimal PrecoDaBroa = 1.50m; //literal real

            decimal valorPaes, valorBroas, total = 0.0m;
            decimal poupanca;

            Console.Write("Digite a quantidade de pães vendidos (R$ 0,12)? ");
            int paesVendidos = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite a quantidade de broas vendidas (R$ 1,50)? ");
            int broasVendidas = Convert.ToInt32(Console.ReadLine());

            valorPaes = paesVendidos * PrecoDoPao;
            valorBroas = broasVendidas * PrecoDaBroa;

            total = valorPaes + valorBroas;
            poupanca = total * 0.1m;

            Console.Write("O total apurado foi: R$" + total);
            Console.Write("\nO que vai para a poupança: R$" + poupanca);

            Console.ReadLine();
        }
    }
}
    
