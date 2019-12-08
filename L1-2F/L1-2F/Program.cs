using System;

namespace L1_2F
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int a, b, c, d, e, cr=10;
            
            for(int i = 0; i < 100000; i++)
            {
                cr--;
                a = rnd.Next(2, 15);
                b = rnd.Next(2, 15);
                c = rnd.Next(2, 15);
                d = rnd.Next(2, 15);
                e = rnd.Next(2, 15);
                Console.WriteLine("{0},{1},{2},{3},{4}", a, b, c, d, e);
                if(a > b)
                {
                    int t = a;
                    a = b;
                    b = t;

                }
                if (a > c)
                {
                    int t = a;
                    a = c;
                    c = t;

                }
                if (a > d)
                {
                    int t = a;
                    a = d;
                    d = t;

                }
                if (a > e)
                {
                    int t = a;
                    a = e;
                    e = t;

                }
                if (b > c)
                {
                    int t = b;
                    b = c;
                    c = t;

                }
                if (b > d)
                {
                    int t = b;
                    b = d;
                    d = t;
                }
                if (b > e)
                {
                    int t = b;
                    b = e;
                    e = t;

                }
                if (c > d)
                {
                    int t = c;
                    c = d;
                    d = t;

                }
                if (c > e)
                {
                    int t = c;
                    c = e;
                    e = t;

                }
                if (d > e)
                {
                    int t = d;
                    d = e;
                    e = t;

                }
                Console.WriteLine("{0} {1} {2} {3} {4}", a, b, c, d, e);
                if((a==b)&&(a==c)&&(a==d)&&(a==e))
                {
                    cr += 1100;
                    Console.WriteLine("5 valori identice");

                }
                else
                {
                    if(((a==b)&&(a==c)&&(a==d))||((b==c)&&(b==d)&&(b==e)))
                    {
                        cr += 40;
                        Console.WriteLine("4 valori identice");
                    }
                    else
                    {
                        if(((a==b)&&(a==c)&&(d==e))||((a==b)&&(c==d)&&(c==e)))
                        { 
                            cr += 10;
                            Console.WriteLine("3+2 valori identice");
                        }
                        else
                        {
                            if(((a==b)&&(b==c))||((b==c)&&(b==d))||((c==d)&&(c==e)))
                                {
                                cr += 3;
                                Console.WriteLine("3 valori identice");
                            }
                            else
                            {
                                if(((a==b)&&(c==d))||((a==b)&&(d==e))||((b==c)&&(d==e)))
                                {
                                    cr += 1;
                                    Console.WriteLine("2 cate 2 valori identice");
                                }
                                else
                                {
                                    if((a==b)||(b==c)||(c==d)||(d==e))
                                    {
                                        cr += 0;
                                        Console.WriteLine(" ");
                                    }
                                }
                            }
                        }
                    }

                }


            }
            Console.WriteLine("cr=" + cr);
            Console.ReadKey();
        }
    }
}
