using System;
using System.IO;
namespace LAB._9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dau doi vectori ordonati cititi din fisier. 
            // Se cere interclasarea lor.
            // Ex. 1 1 4 13   1 2 3 5 10
            // interclasarea: 1 1 1 2 3 /**/4 5 10 13

            TextReader load = new StreamReader(@"..\..\resurse\TextFile1.txt");
            string d1 = load.ReadLine();
            string d2 = load.ReadLine();
            string[] t1 = d1.Split(' ');
            string[] t2 = d2.Split(' ');
            Console.WriteLine("d1={0}, d2={1}", d1, d2);
            /*
            int[] v1 = new int[100];
            string[] t1 = d1.Split(' ');
            for(int i=0; i<t1.Length; i++)
            {
                v1[int.Parse(t1[i])]++;
            }
            string[] t2 = d2.Split(' ');
            for (int i = 0; i < t2.Length; i++)
            {
                v1[int.Parse(t2[i])]++;
            }
            for(int i=0; i<100; i++)
            {
                for (int j = 0; j < v1[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }*/
            int[] v1 = new int[t1.Length];
            for(int q=0; q<t1.Length; q++)
            {
                v1[q] = int.Parse(t1[q]);
            }
            int[] v2 = new int[t2.Length];
            for (int q = 0; q < t2.Length; q++)
            {
                v2[q] = int.Parse(t2[q]);
            }
            int[] v3 = new int[t1.Length + t2.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < t1.Length && j < t2.Length)
            {
                if (v1[i] < v2[j])
                {
                    v3[k] = v1[i];
                    i++;
                    k++;
                }
                else
                {
                    v3[k] = v2[j];
                    j++;
                    k++;

                }
            }
            while(i<t1.Length)
            {
                v3[k] = v1[i];
                k++;
                i++;
            }
            while(j<t2.Length)
            {
                v3[k] = v2[j];
                k++;
                j++;
            }
            Console.WriteLine();

            for(int q=0; q<t1.Length+t2.Length; q++)
            {
                Console.Write(v3[q] + " ");



            }

            Console.ReadKey();
        }
    }
}
