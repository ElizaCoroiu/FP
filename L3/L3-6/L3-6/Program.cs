using System;

namespace L3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int t = a * b;
            while(a!=b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;

            }
            Console.WriteLine("cmmdc="+a);
            Console.WriteLine("cmmmc=" + (t / a));
            Console.ReadKey();
        }
    }
}
