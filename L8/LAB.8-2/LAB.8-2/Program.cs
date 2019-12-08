using System;

namespace LAB._8_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Se dau doi vectori cu valori
            // cuprinse intre 0 si 100
            // Intersectia, reuniunea, diferenta, incluziunea ...

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int[] v1 = new int[n1];
            int[] v2 = new int[n2];

            for(int i=0; i<n1; i++)
            {
                v1[i] = rnd.Next(101);
            }

            for (int i = 0; i < n2; i++)
            {
                v2[i] = rnd.Next(101);
            }

            for (int i = 0; i < n1; i++)
            {
                Console.Write("v1["+i+"]=" + v1[i]+" ");
            }

            Console.WriteLine();

            for (int i = 0; i < n2; i++)
            {
                Console.Write("v2["+i+"]=" + v2[i]+" ");
            }
            Console.WriteLine();

            //// intersectia

            //for(int i=0; i<n1; i++)
            //{
            //    for(int j=0; j<n2; j++)
            //    {
            //        if (v1[i] == v2[j])
            //            Console.Write(v1[i] + " ");
            //    }
            //}
            //// reuniune

            //int[] v3 = new int[n1 + n2];

            //for(int i=0; i<n1; i++)
            //{
            //    v3[i] = v1[i];
            //}
            //for(int i=0; i<n2; i++)
            //{
            //    v3[n1 + i] = v2[i];
            //}
            //for(int i=0; i<n1+n2; i++)
            //{
            //    Console.Write(v3[i] + " ");
            //}
            //Console.WriteLine();

            //for(int i=0; i<n1+n2-1; i++)
            //{
            //    for(int j=i+1; j<n1+n2; j++)
            //    {
            //        if(v3[i]<v3[j])
            //        {
            //            int aux = v3[i];
            //            v3[i] = v3[j];
            //            v3[j] = aux;
            //        }
            //    }
            //}
            //for (int i = 0; i < n1 + n2; i++)
            //{
            //    Console.Write(v3[i] + " ");
            //}
            //Console.WriteLine();

            //Console.Write(v3[0] + " ");

            //for (int i = 1; i < n1 + n2; i++)
            //{
            //    if (v3[i] != v3[i - 1])
            //    {
            //        Console.Write(v3[i]+" ");
            //    }
            //}
            //Console.WriteLine();

            //// diferenta

            //for (int i = 0; i < n1; i++)
            //{
            //    bool ok = true;
            //    for(int j=0; j<n2; j++)
            //    {
            //        if (v1[i] == v2[j])
            //            ok = false;
            //    }
            //    if (ok)
            //        Console.Write(v1[i] + " ");
            //}
            //Console.WriteLine();

            // met II

            int[] v1N = new int[101];
            int[] v2N = new int[101];

            for (int i = 0; i < 101; i++)
            {
                v1N[i] = 0;
                v2N[i] = 0;
            }

            for(int i=0; i<n1; i++)
            {
                v1N[v1[i]]++;
            }
            for (int i = 0; i < n2; i++)
            {
                v2N[v2[i]]++;
            }
            Console.WriteLine("Vectorii de aparitie:");

            for(int i=0; i<101; i++)
            {
                Console.Write(v1N[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 101; i++)
            {
                Console.Write(v2N[i] + " ");
            }
            Console.WriteLine();

            // intersectia

            for(int i=0; i<101; i++)
            {
                if (v1N[i] != 0 && v2N[i] != 0)
                    Console.Write(i+" ");
            }
            Console.WriteLine();

            // reuniunea

            for (int i = 0; i < 101; i++)
            {
                if (v1N[i] != 0 || v2N[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            // diferenta 
            for (int i = 0; i < 101; i++)
            {
                if (v1N[i] != 0 && v2N[i] == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 101; i++)
            {
                if (v1N[i] == 0 && v2N[i] != 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
