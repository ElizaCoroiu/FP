using System;

namespace LAB._8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se da un vector. Sa se afiseze 
            // elem in urmatoarea ordine (1 8 2 7 3 6 4 5)

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            for(int i=0; i<n/2; i++)
            {
                Console.Write(v[i]+" "+ v[n - 1 - i]+" ");
            }
            if (n % 2 == 1)
            {
                Console.Write(v[n / 2]);
            }


            Console.ReadKey();
        }
    }
}
