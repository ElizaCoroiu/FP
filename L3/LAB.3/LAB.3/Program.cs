using System;

namespace LAB._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex.1 Ecuatia de gr II
            /*
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            float delta = b * b - 4 * a * c;

            if(delta>0)
            {
                float x1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                float x2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);

                Console.Write("x1={0},x2={1}", x1, x2);
            }else
            if(delta==0)
            {

                float x = -b / (2 * a);
                Console.Write("x=" + x);

            }else
            if(delta<0)
                {
                float Real = -b / (2 * a);
                float Img = (float)Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("x1={0}+i{1}", Real, Img);
                Console.Write("x2={0}-i{1}", Real, Img);
               
                }*/
            //ex.2 Se dau 5 nr. Calc suma maxima a 3 dintre ele
            /*
            int d, e, f, g, h;
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            f = int.Parse(Console.ReadLine()); 
            g = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            if(d > e)
            {
                int t = d;
                d = e;
                e = t;
            }
            if (d > f)
            {
                int t = d;
                d = f;
                f = t;
            }
            if (d > g)
            {
                int t = d;
                d = g;
                g = t;
            }
            if (d > h)
            {
                int t = d;
                d = h;
                h = t;
            }
            if (e > f)
            {
                int t = e;
                e = f;
                f = t;
            }
            if (e > g)
            {
                int t = e;
                e = g;
                g = t;
            }
            if (e > h)
            {
                int t = e;
                e = h;
                h = t;
            }
            if (f > g)
            {
                int t = f;
                f = g;
                g = t;
            }
            if (f > h)
            {
                int t = f;
                f = h;
                h = t;
            }
            if (g > h)
            {
                int t = g;
                g = h;
                h = t;
            }
            Console.WriteLine("f+g+h="+(f+g+h));
            */

            //ex.3 Pentru n dat, afisati seria.
            /*
            int n;
            n = int.Parse(Console.ReadLine());
            while(n!=1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    
                }
                else
                    n = n * 3 + 1;
                Console.WriteLine(n);
            }
            */
            /* ex.4 Se dau 8 valori reprezentand 4 puncte in plan Ax Ay Bx By Cx Cy Dx Dy.
            Se cere afisarea punctului de intersectie al dreptelor AB intersectat CD*/
            float Ax = float.Parse(Console.ReadLine());
            float Ay = float.Parse(Console.ReadLine());
            float Bx = float.Parse(Console.ReadLine());
            float By = float.Parse(Console.ReadLine());
            float Cx = float.Parse(Console.ReadLine());
            float Cy = float.Parse(Console.ReadLine());
            float Dx = float.Parse(Console.ReadLine());
            float Dy = float.Parse(Console.ReadLine());

            float a = Bx - Ax;
            float b = By - Ay;
            float c = Dx - Cx;
            float d = Dy - Cy;
            float t1 = b * Ax - a * Ay;
            float t2 = d * Cx - c * Cy;
            float ds = a * d - b * c;
            float dx = t2 * a- t1*c;
            float dy = t2 * b - t1 * d;

            float x = dx / ds;
            float y = dy / ds;

            Console.WriteLine("x={0}, y={1}", x, y);
            

            Console.ReadKey();


        }
    }
}
