using System;

namespace LAB._7
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
            // sortare elem vector
            // met.I
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (v[i] > v[j])
            //        {
            //            int aux = v[i];
            //            v[i] = v[j];
            //            v[j] = aux;
            //        }


            //    }
            //}
            //for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(v[i] + " ");
            //    }

            // met. II (Bubble Sort)
            bool ok;
            do
            {
                ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int aux = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = aux;
                        ok = false;
                    }
                }
            } while (!ok);
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            // met. III (Selection Sort)
            for (int j = 0; j < n - 1; j++)
            {
                int min = v[j];
                int poz = j;
                for (int i = j + 1; i < n; i++)
                {
                    if (v[i] < min)
                    {
                        min = v[i];
                        poz = i;
                    }
                }
                int aux = v[j];
                v[j] = v[poz];
                v[poz] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
