using System;

namespace LAB._9_1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Se da un vector de n valori intregi
            // Se cere cele mai mari 3 valori

            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] s = new int[n];
            for (int i = 0; i < n; i++)
            {
                //Console.Write("v[{0}]=", i);
                //v[i] = int.Parse(Console.ReadLine());

                v[i] = rnd.Next(10000);
                s[i] = v[i];
            }
            for(int i=0; i<n; i++)
            {
                Console.Write(v[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] < v[j])
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Cele 3 valori sunt:{0}, {1}, {2}", v[0], v[1], v[2]);
            Console.WriteLine();
            // met II

            int max = v[0];
            int poz = 0;
            int min = v[0];
            for(int i=1; i<n; i++)
            {
                if (max < v[i])
                {
                    max = v[i];
                    poz = i;
                }
                    
                if (min > v[i])
                    min = v[i];
            }
            Console.Write(max+" ");
            v[poz] = min;
            max = v[0];
            poz = 0;
            for (int k = 1; k < n; k++)
            {
                if (max < v[k])
                {
                    max = v[k];
                    poz = k;
                }
            }
            Console.Write(max + " ");
            v[poz] = min;
            max = v[0];
            poz = 0;
            for (int i = 1; i < n; i++)
            {
                if (max < v[i])
                {
                    max = v[i];
                    poz = i;
                }
            }
            Console.Write(max + " ");
            Console.WriteLine();
            // met III
            int m1 = s[0];
            int m2 = s[1];
            int m3 = s[2];

            if(m1>m2)
            {
                int aux = m1;
                m1 = m2;
                m2 = aux;
            }
            if (m1 > m3)
            {
                int aux = m1;
                m1 = m3;
                m3 = aux;
            }
            if (m2 > m3)
            {
                int aux = m2;
                m2 = m3;
                m3 = aux;
            }

            for (int i = 3; i < n; i++)
            {
                if (s[i] >= m3)
                {
                    m1 = m2;
                    m2 = m3;
                    m3 = s[i];
                }
                else 
                {
                    if (s[i] >= m2)
                    {
                        m1 = m2;
                        m2 = s[i];
                    }
                    else
                    {
                        if (s[i] >= m1)
                            m1 = s[i];
                    }
                }
            }
            Console.Write(m3+" "+m2+" "+m1+" ");
            Console.ReadKey();
        }
    }
}
