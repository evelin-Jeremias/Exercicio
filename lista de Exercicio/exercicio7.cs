namespace Exercicio7.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)

		{
			Console.WriteLine("Informe o salário base do vendedor: ");
			double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do vendedor: ");
            double TotalVendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual da comissão sobre as vendas (%) : ");
            double PercentualComissão = Convert.ToDouble(Console.ReadLine());

			double comissão = (PercentualComissão / 100) * TotalVendas;	

			double salarioTotal = salarioBase + comissão;

			Console.WriteLine("O salario total do vendedor é: " + salarioTotal);

			Console.ReadLine();
        }
	}
}
