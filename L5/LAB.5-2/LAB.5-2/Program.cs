using System;

namespace LAB._5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            bool ok = true;
            for(int i=0; i<n/2; i++)
            {
                if(v[i]!=v[n-i-1])
                {
                    ok = false;
                    break;
                }
            }
            if(ok==true)
            {
                Console.WriteLine("Palindrom");
            }
            //Afisarea inversa a vectorului
            Console.WriteLine();
            for(int i=n-1; i>=0; i--)
            {
                Console.Write("v[{0}]={1} ", i, v[i]);
            }
            Console.WriteLine();
            //Interschimbare
            for(int i=0; i<n/2; i++)
            {
                int aux = v[i];
                v[i] = v[n - 1 - i];
                v[n - 1 - i] = aux;
            }
            for(int i=0; i<n; i++)
            {
                Console.Write("v[{0}]={1} ", i, v[i]);
            }
            Console.ReadKey();
        }
    }
}
