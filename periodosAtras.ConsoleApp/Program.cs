using System;

namespace periodosAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataInicial = new DateTime(2009, 05, 12, 12, 04, 15);

            DateTime dataFinal = DateTime.Now;

            TimeSpan diferenca = dataFinal.Subtract(dataInicial);
            int contadorAnos = 0, contadorMeses = 0;
            int diferencaEmDias = Convert.ToInt16(diferenca.Days); ;


            if (diferencaEmDias >= 365)
            {
                while (diferencaEmDias >= 365)
                {
                    diferencaEmDias = diferencaEmDias - 365;
                    contadorAnos++;
                }

                Console.Write(contadorAnos + " anos ");

            }

            if (diferencaEmDias < 365 && diferencaEmDias >= 30)
            {
                
                while (diferencaEmDias >= 30)
                {
                    diferencaEmDias = diferencaEmDias - 30;
                    contadorMeses++;

                }

                Console.Write(contadorMeses + " meses " + diferencaEmDias + " dias atrás.");

            }

            



            if (diferenca.Days <= 0 && diferenca.Hours <= 0)
            {
                if (diferenca.Minutes <= 0)
                    Console.WriteLine(diferenca.Seconds + " segundos atrás.");

                else if (diferenca.Minutes <= 60 && diferenca.Seconds <= 0)
                    Console.WriteLine(diferenca.Minutes + " minutos atrás.");

                else if (diferenca.Minutes <= 60 && diferenca.Seconds > 0)
                    Console.WriteLine(diferenca.Minutes + " minutos e " + diferenca.Seconds + " segundos atrás.");
                
            }


           


            /*
            Console.WriteLine("Time Difference (seconds): " + diferenca.Seconds);
            Console.WriteLine("Time Difference (minutes): " + diferenca.Minutes);
            Console.WriteLine("Time Difference (hours): " + diferenca.Hours);
            Console.WriteLine("Time Difference (days): " + diferenca.Days);
            */
        }
    }
}
