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

            double x = 0, y = 0;
            int n = 1, t = 0;
            double z = 0;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());

            int i = 1, step = 1;
            double znam = 1, chisl;
            if (t == 0)
            {
                for (i = 1; i <=n; i++)
                {
                    step = 2 * i - 1;
                    znam = step * (step + 1) * (step + 2);
                    if (i % 2 == 0) 
                        chisl =   Math.Pow(y, step);
                    else
                        chisl =  -Math.Pow(x, step);
                    z += chisl / znam;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i <=n)
                {
                    step = 2 * i - 1;
                    znam = step * (step + 1) * (step + 2);
                    if (i % 2 == 0)
                        chisl =  Math.Pow(y, step);
                    else
                        chisl =  -Math.Pow(x, step);
                    z += chisl / znam;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    step = 2* i - 1;
                    znam = step * (step + 1) * (step + 2);
                    if (i % 2 == 0)
                        chisl =  Math.Pow(y, step);
                    else
                        chisl =  -Math.Pow(x, step);
                    z += chisl / znam; 
                    i++;
                } while (i <= n);
            }

            Console.WriteLine(String.Format("{0:0.0000000}", z));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
