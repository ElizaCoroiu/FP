using System;

namespace Partial_28._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se afiseze ultima cifra a numarului n^n 
            int total_a = 0;
            int total_b = 1;
            int p;

            Console.Write("Introduceti numarul de cifre dorit: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele: ");

            for (int i = 0; i < n; i++)
            {
                p = int.Parse(Console.ReadLine());
                total_a += p;
                total_b *= p;

            }
            float ar_average = total_a / n;
            float geo_average = (float)Math.Pow(total_b, (float)1.0 / (float)n);

            Console.WriteLine("Media aritmetica e: {0}\nIar media geometrica e: {1}", ar_average, geo_average);

            //(b)

            int integer = (int)ar_average;
            while(integer != 0)
            {
                Console.Write(integer % 7);
                integer /= 7;
            }
            Console.ReadKey();

        }
    }
}
