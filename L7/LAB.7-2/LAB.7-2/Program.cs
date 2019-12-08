using System;

namespace LAB._7_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            // cautam de cate ori apare 0 in vector
            //int nr0 = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (v[i] == 0)
            //        nr0++;
            //}
            //Console.Write(nr0);

            int[] vn = new int[100];
            for (int i = 0; i < 100; i++)
            {
                vn[i] = 0;
            }


            for (int i = 0; i < n; i++)
            {
                vn[v[i]]++;
            }
            for (int i = 0; i < 100; i++)
                Console.Write(vn[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < vn[i]; j++)
                    Console.Write(i + " ");
            }

        }
    }
}
