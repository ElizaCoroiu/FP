using System;

namespace L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                float x1 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                Console.Write("x1={0}, x2={1}", x1, x2);
            }else
            if (delta == 0)
            {
                float x = -b / (2 * a);
                Console.Write("x=" + x);   
            }else
            if (delta < 0)
            {
                float Real = -b / (2 * a);
                float Img = (float)Math.Sqrt(-delta) / (2 * a);
                Console.Write("x1={0}-i{1}, x2={0}-i{1}", Real, Img); 
            }
            Console.ReadKey
        }
    }
}
