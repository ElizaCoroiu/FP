using System;

namespace LAB._6_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Se da o matrice de 3 pe 3. Utilizatorul va selecta
            // o pozitie din matrice care va fi selectata cu x.
            //Calc va rasp cu o alta pozitie din matrice pe care 
            //o vom nota cu 0. Jocul continua pana cand calc obtine
            //3 simboluri identice pe linie/diagonala/coloana

            int[,] m = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    m[i, j] = 0;
            }
            bool ok;
            do
            {
                
                Console.WriteLine("Insert location");
                int lin = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());
                
                m[lin, col] = 1;
                int l1, c1;
                do
                {
                    l1 = rnd.Next(3);
                    c1 = rnd.Next(3);
                } while (m[l1, c1] != 0);

                m[l1, c1] = 2;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (m[i, j] == 0)
                            Console.Write("[ ]");
                        if (m[i, j] == 1)
                            Console.Write("[X]");
                        if (m[i, j] == 2)
                            Console.Write("[0]");
                    }
                    Console.WriteLine();

                }

                // linie/coloana/diagonala cu simboluri identice
                ok = false;
                if (m[0, 0] == m[0, 1] && m[0, 0] == m[0, 2] && m[0,0]!=0)
                    ok = true;
                if (m[1, 0] == m[1, 1] && m[1, 0] == m[1, 2] && m[1, 0] != 0)
                    ok = true;
                if (m[2, 0] == m[2, 1] && m[2, 0] == m[2, 2] && m[2, 0] != 0)
                    ok = true;
                if (m[0, 0] == m[1, 0] && m[0, 0] == m[2, 0] && m[0, 0] != 0)
                    ok = true;
                if (m[0, 1] == m[1, 1] && m[0, 1] == m[2, 1] && m[0, 1] != 0)
                    ok = true;
                if (m[0, 2] == m[1, 2] && m[0, 2] == m[2, 2] && m[0, 2] != 0)
                    ok = true;
                if (m[0, 0] == m[1, 1] && m[0, 0] == m[2, 2] && m[0, 0] != 0)
                    ok = true;
                if (m[0, 2] == m[1, 1] && m[0, 2] == m[2, 0] && m[0, 2] != 0)
                    ok = true;

            } while (ok==false);
        }
    }
}
