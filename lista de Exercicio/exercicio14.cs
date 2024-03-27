namespace Exercicio14.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string nome;
            int idade, diasDeVida;
            const int qtdDiasNoAno = 365;

            Console.Write("Por favor, informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nAgora informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            diasDeVida = idade * qtdDiasNoAno;

            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias");

            Console.ReadLine();
        }
    }
}
