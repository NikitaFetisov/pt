using System;
using System.IO;

namespace Test
{
    class triangle
    {
        private double a, b;

        private triangle() { }

        public triangle(double pA, double pB)
        {
            a = pA;
            b = pB;
        }

        public double GetGip() { return Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2))); }

        public double GetS() { return (a * b) / 2; }

        public double GetP() { return a + b + GetGip(); }

        public void Info()
        {
            String str =
                "    *\n" +
                "    **\n" +
                "    * *\n" +
                "    *  *\n" +
                "    *   *\n" +
                "    *    *\n" +
                "    *     *\n" +
                "    *      *\n" +
                "    *       *\n" +
               " " + a + "  *        *\n" +
                "    * right   *   " + GetGip() + "\n" +
                "    *triangle  *\n" +
                "    *           *\n" +
                "    *            *\n" +
                "    *             *\n" +
                "    *              *\n" +
                "    *               *\n" +
                "    *                *\n" +
                "    *******************\n" +
                "           " + b;
            ;
            Console.WriteLine(str);
            Console.WriteLine(string.Format("A = {0:0.000}", a));
            Console.WriteLine(string.Format("B = {0:0.000}", b));
            Console.WriteLine(string.Format("Gipotenusa = {0:0.000}", GetGip()));
            Console.WriteLine(string.Format("S = {0:0.000}", GetS()));
            Console.WriteLine(string.Format("P = {0:0.000}", GetP()));
        }

        private void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }
        public static triangle CreateTriangleFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            return new triangle(aa, bb);
        }
        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
        }
    }
    class programm
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"triangle_output.txt");
            var new_in = new StreamReader(@"triangle_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            triangle p1, p2;
#if DEBUG
            p2 = new triangle(5.7, 11);
            p2.Info(ConsoleColor.Red, ConsoleColor.Green);
#endif
#if !DEBUG
            p1 = triangle.CreateTriangleFromFile();
            p1.Info();
            p2 = new triangle(5.6, 5.11);
            p2.Info();
#endif
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close(); 
#endif
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}

