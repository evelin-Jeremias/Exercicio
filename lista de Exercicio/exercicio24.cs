namespace Exercicio24.ConsoleApp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Digite um número de 1 a 10: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                int resultado = i * n;
                Console.WriteLine("{0} x {1} = {2}", i, n, resultado);

                Console.WriteLine(i + " x " + n + " = " + resultado);
            }

            Console.ReadLine();
        }
    }
}
