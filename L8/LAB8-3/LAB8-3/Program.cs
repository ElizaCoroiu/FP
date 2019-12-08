using System;

namespace LAB8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dau 2 nr. n, m. Afisati cifrele comune si necomune


            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());



            int[] v1 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] v2 = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            while (n != 0)
            {
                v1[n % 10]++;
                n = n / 10;
            }
            while (m != 0)
            {
                v2[m % 10]++;
                m = m / 10;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v1[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(v2[i]);
            }
            Console.WriteLine();
            // intersectia
            for (int i = 0; i < 10; i++)
            {
                if (v1[i] != 0 && v2[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
            // reuniunea
            for (int i = 0; i < 10; i++)
            {
                if (v1[i] != 0 || v2[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
