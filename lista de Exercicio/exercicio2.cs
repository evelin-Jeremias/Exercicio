

using System.ComponentModel;

namespace lista_de_Exercicio
{
    internal class exercicio2
    {
        static void Main(string[] args)
        {
            #region Input de dados
            //Entrada de dados

            decimal temperaturaFahrenheit;

            // Saisa de Dados
            decimal temperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            #endregion

            #region processamento
            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
            #endregion

            #region output de dados
            Console.WriteLine("");
    }
    }

