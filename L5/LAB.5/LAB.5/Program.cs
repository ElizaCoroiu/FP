using System;

namespace LAB._5
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] v = new int[n];
            //for(int i=0; i<n;i++)
            //{
            //    Console.Write("v[{0}]=", i);
            //    v[i] = int.Parse(Console.ReadLine());
            //}
            //ex1. Se da un vector de n elem. Se cere suma elem. vect
            //int suma = 0;
            //for(int i=0;i<n;i++)
            //{
            //    suma += v[i];
            //}
            //Console.WriteLine("Suma elementelor={0}",suma);
            ////ex.2 Minimul dintr-un vector
            //int min = v[0];
            //for(int i=1; i<n; i++)
            //{
            //    if(v[i]<min)
            //    {
            //        min = v[i];
            //    }
            //}
            //Console.WriteLine("Minimul={0}",min);
            ////ex.3 Afisarea elem. vectorului
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(v[i]+" ");
            //}
            //Console.WriteLine();
            ////ex.4 Sortarea cea mai neeficiente a unui vector, dar care functioneaza pana nu stim sortari mai eficiente 
            //for(int i=0; i<n-1; i++)
            //{
            //    for(int j=i+1; j<n; j++)
            //    {
            //        if(v[i]<v[j])
            //        {
            //            int aux = v[i];
            //            v[i] = v[j];
            //            v[j] = aux;
            //        }
            //    }

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(v[i] + " ");
            //}
            //Console.WriteLine();
            ////ex.5 Se da un vector de n elem. cu valori intre 0 si 5000. Se cere sa se afiseze toate elem vect a caror scriere in baza 2 contine doar cifre de 1.
            //for(int i=0; i<n; i++)
            //{
            //    int r = v[i];
            //    bool ok = true;
            //    while(r!=0)
            //    {
            //        if ((r % 2) == 0)
            //        {
            //            ok = false;
            //            break;
            //        }


            //        r = r / 2;

            //    }
            //    if(ok)
            //    {
            //        Console.Write(v[i]+" ");

            //    }



            //}
            //Console.WriteLine();
            ////Met 2
            //for(int i=0; i<n; i++)
            //{
            //    for(int j=0; j<=12; j++)
            //    {
            //        if(v[i]==((int)Math.Pow(2, j)-1))
            //        {
            //            Console.Write(v[i]+" ");
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine();
            ////Met. 3
            //int[] v2 = new int[] { 1, 3, 7, 15, 31, 63, 127, 255, 511, 1023, 2047, 4095 };
            //for(int i=0; i<n; i++)
            //{
            //    for(int j=0; j<v2.Length; j++)
            //    {
            //        if(v[i]==v2[j])
            //        {
            //            Console.Write(v[i]+" ");
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //ex.6 Vector de valori aleatoare
            int n = 10;
            int nr = 0;
            int[] v = new int[n];
            for (int j = 0; j < 10000; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    v[i] = rnd.Next(-10, 11);
                }
                //for(int i=0; i<n; i++)
                //{
                //    Console.Write("v[{0}]={1} ", i, v[i]);
                //}
                //Vector de "tip munte"
                bool ok = false, ok2 = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (!ok)
                    {
                        if (v[i] > v[i + 1])
                        {
                            ok = true;
                        }
                    }
                    else
                    {
                        if (v[i] < v[i + 1])
                        {
                            ok2 = false;
                        }
                    }

                }
                if (ok2)
                    nr++;
                Console.Write(j);
            }
            
            Console.WriteLine((float)nr / 10000.0);
                //Console.WriteLine("Munte");
            //else
               // Console.WriteLine("Nu e munte");
            //met. 2-cautam max si pozitia lui
            //int max = v[0];
            //int poz = 0;
            //for(int i=1; i<n; i++)
            //{
            //    if(max<v[i])
            //    {
            //        max = v[i];
            //        poz = i;
            //    }
            //}
            //ok = true;
            //for(int i=0; i<poz; i++)
            //{
            //    if (v[i] > v[i + 1])
            //    {
            //        ok = false;
            //    }
            //}
            //for(int i=poz; i<n-1; i++)
            //{
            //    if(v[i]<v[i+1])
            //    {
            //        ok = false;
            //    }
            //}
            //if (ok)
            //    Console.WriteLine("Munte");
            //else
            //    Console.WriteLine("Nu e munte");
            Console.ReadKey();
        }
    }
}
