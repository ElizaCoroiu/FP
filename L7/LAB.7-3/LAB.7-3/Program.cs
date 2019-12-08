using System;

namespace LAB._7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se da un nr. 
            // Sa se verifice daca are toate cifrele

            int n = int.Parse(Console.ReadLine());
            int[] vn = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            while (n != 0)
            {
                vn[n % 10]++;
                n = n / 10;
            }
            bool ok = true;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vn[i] + " ");
            }
            for (int i = 0; i < 10; i++)
            {
                if (vn[i] == 0)
                    ok = false;
            }
            if (ok)
                Console.WriteLine("Nr. t");

        }
    }
}
