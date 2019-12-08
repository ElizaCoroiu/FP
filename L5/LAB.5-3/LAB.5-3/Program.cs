using System;

namespace LAB._5_3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Cele mai mari 3 valori maxime dintr-un vector
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int[] v = new int[n];
            int[] v1 = new int[n];
            for(int i=0; i<n; i++)
            {
                v[i] = rnd.Next(0, 100);
                v1[i] = v[i];
            }
            for(int i=0; i<n; i++)
            {
                Console.Write(v[i]+" ");
            }
            for(int i=0; i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(v[i]<v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                        nr++;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("max1={0}, max2={1}, max3={2}", v[0], v[1], v[2]);
            Console.WriteLine(nr);
            //Met. 2
            int nr2 = 0;
            int max1 = v1[0];
            int max2 = v1[1];
            int max3 = v1[2];
            if (max1 > max2)
            {
                int aux = max1;
                max1 = max2;
                max2 = aux;
                nr2++;
            }
            if (max1 > max3)
            {
                int aux = max1;
                max1 = max3;
                max3 = aux;
                nr2++;
            }
            if (max2 > max3)
            {
                int aux = max2;
                max2 = max3;
                max3 = aux;
                nr2++;
            }
            for(int i=2; i<n; i++)
            {
                if((max1<=v[i])&&(v[i]<max2))
                {
                    max1 = v[i];
                    nr2++;
                }
                if ((max2 <= v[i]) && (v[i] < max3))
                {
                    max1 = max2;
                    max2 = v[i];
                    nr2++;
                }
                if(max3<=v[i])
                {
                    max1 = max2;
                    max2 = max3;
                    max3 = v[i];
                    nr2++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("max1={0}, max2={1}, max3={2}", max1, max2, max3);
            Console.WriteLine(nr2);
            Console.ReadKey();
        }

    }
}
