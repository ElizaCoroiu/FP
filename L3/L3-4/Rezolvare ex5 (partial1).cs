using System;

namespace L3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float Ax=  float.Parse(Console.ReadLine());
            float Bx = float.Parse(Console.ReadLine());
            float Cx = float.Parse(Console.ReadLine());
            float Dx = float.Parse(Console.ReadLine());
            float Ay = float.Parse(Console.ReadLine());
            float By = float.Parse(Console.ReadLine());
            float Cy = float.Parse(Console.ReadLine());
            float Dy = float.Parse(Console.ReadLine());
            float x = ((Ax * By - Ay * By) * (Cx - Dx) - (Cx * Dy - Cy * Dx) * (Ax * Bx)) / ((By - Ay) * (Cx - Dx) - (Dy - Cy) * (Ax - Bx));
            float y = ((By - Ay) * (Cx * Dy - Cy * Dx) - (Dy - Cy) * (Ax * By - Ay * Bx)) / ((By - Ay) * (Cx - Dx) - (Dy - Cy) * (Ax - Bx));
            Console.WriteLine("{0},{1}", x, y);
            float a = Bx - Ax;
            float b = By - Ay;
            float c = Dx - Cx;
            float d = Dy - Cy;
            float t1 = b * Ax - a * Ay;
            float t2 = d * Cx - c * Cy;
            float ds = a * d - b * c;
            float dx = a*t2 - c*t1;
            float dy = b * t2 - d * t1;
            x = dx / ds;
            y = dy / ds;
                Console.WriteLine("{0},{1}", x, y);
            Console.ReadKey();
        }
        
    }
}
