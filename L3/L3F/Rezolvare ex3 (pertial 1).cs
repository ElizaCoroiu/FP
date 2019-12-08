using System;

namespace L3F
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n!=1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = n * 3 + 1;
                Console.Write(n + " ");
            }
            Console.ReadKey();
                
        }
    }
}
