using System;

namespace L3_5
{
    class Program
    {
        static Random Rnd = new Random();
        static void Main(string[] args)
        {
            int nc = Rnd.Next(101);
            int nu, n=0;
            do
            {
                n++;
                nu = int.Parse(Console.ReadLine());
                if (nu < nc)
                    Console.Write("Incearca mai mare!");
                if (nu > nc)
                    Console.WriteLine("Incearca mai mic!");
            }
            while (nu != nc);
            Console.WriteLine("Ai castigat!"+n+"incercari" );
            Console.ReadKey();
        }
    }
}
