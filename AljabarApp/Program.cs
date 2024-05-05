using System;

namespace AljabarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mencari akar persamaan kuadrat:");
            double[] persamaan = { 1, -3, -10 };
            double[] akar = AljabarLibraries.Aljabar.AkarPersamaanKuadrat(persamaan);
            Console.WriteLine($"Akar persamaan kuadrat: {akar[0]} dan {akar[1]}");

            Console.WriteLine("\nMendapatkan hasil kuadrat:");
            double[] hasilKuadrat = AljabarLibraries.Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine($"Hasil kuadrat: {hasilKuadrat[0]}x^2 + {hasilKuadrat[1]}x + {hasilKuadrat[2]}");

            Console.ReadLine();
        }
    }
}
