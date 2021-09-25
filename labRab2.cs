using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            double a, c, d, e;
            double s, k;
            a = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((a <= 0) || (c <= 0) || (((Math.Pow(c, 2)) - (Math.Pow(d, 3)) <= 0)))
                Console.WriteLine("ERROR");
            else
            {
                s = (Math.Pow(a, 2)) / ((Math.Pow(c, 2)) - (Math.Pow(e, 2)));
                Console.WriteLine(String.Format("{0:0.000}", s));
                k = (Math.Sqrt(a - Math.Pow(c, 2)) / Math.Sqrt(Math.Pow(c, 2) - Math.Pow(d, 3)));
                Console.WriteLine(String.Format("{0:0.000}", k));
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}