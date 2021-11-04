using System;
using System.IO;

namespace Test
{
    class triangle
    {
        private double a, b;

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
        
        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
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
            triangle t = new triangle();
            t.Load();
            t.Info();
#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}
