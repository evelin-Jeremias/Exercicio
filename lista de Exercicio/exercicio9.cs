using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_de_Exercicio
{
    internal class exercicio9
    {

       static  void Main(string[] args)
        {
            decimal nota1, nota2,nota3,nota4;

            Console.WriteLine("Digite as quatro notas do aluno");
            nota1 = Convert.ToDecimal(Console.ReadLine());
            nota2 = Convert.ToDecimal(Console.ReadLine());
            nota3 = Convert.ToDecimal(Console.ReadLine());
            nota4 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));

            Console.WriteLine("A media harmonica das notas é: " + mediaHarmonica);

            Console.ReadLine(); 
        }
    }
}
