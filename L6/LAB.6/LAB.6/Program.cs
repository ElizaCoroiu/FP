using System;

namespace LAB._6
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Se da o matrice de 3 pe 3 care se genereaza aleator in care se introduc valori de la 1 la 10(aleator).Sa se verifice daca exista 3 val identice pe linie, pe diagonala sau pe coloana.
            
            int[] v1 = new int[3];
            int[] v2 = new int[3];
            int[] v3 = new int[3];
            int cr = 0;

            do
            {

                cr--;

                for (int i = 0; i < 3; i++)
                {
                    int t = rnd.Next(5);
                    if(t!=4)
                       v1[i] = rnd.Next(1, 5);
                    else
                        v1[i] = rnd.Next(5, 10);
                    t = rnd.Next(5);
                    if (t != 4)
                        v2[i] = rnd.Next(1, 5);
                    else
                        v2[i] = rnd.Next(5, 10);
                    t = rnd.Next(5);
                    if (t != 4)
                        v3[i] = rnd.Next(1, 5);
                    else
                        v3[i] = rnd.Next(5, 10);
                }
                for (int i = 0; i < 3; i++)
                    Console.Write(v1[i] + " ");
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                    Console.Write(v2[i] + " ");
                Console.WriteLine();
                for (int i = 0; i < 3; i++)
                    Console.Write(v3[i] + " ");
                Console.WriteLine();

                int nr = 0;

                if (v1[0] == v1[1] && v1[0] == v1[2])
                    nr++;
                if (v2[0] == v2[1] && v2[0] == v2[2])
                    nr++;
                if (v3[0] == v3[1] && v3[0] == v3[2])
                    nr++;
                if (v1[0] == v2[0] && v1[0] == v3[0])
                    nr++;
                if (v1[1] == v2[1] && v1[1] == v3[1])
                    nr++;
                if (v1[2] == v2[2] && v1[2] == v3[2])
                    nr++;
                if (v1[0] == v2[1] && v1[0] == v3[2])
                    nr++;
                if (v1[2] == v2[1] && v1[2] == v3[0])
                    nr++;
                cr += nr * 3;

                Console.WriteLine(cr);
                
                Console.ReadKey();
            } while (true);

        }

    }
}
