using System;
using System.IO;

namespace Лаба4
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

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            int s = 0;
            float sa = 0;
            int MAX = 0;
            int MIN = 100000;
            float saMAXandMIN;

            //Вычисление среднего арифметического всех элементов

            for (int i = 0; i < N; i++)
            {
                s += mas[i];
            }
            sa = 1.0f * s / N;

            //Вычисление среднего арифметического Максимального и минимального элементов

            for (int i = 0; i < N; i++)
            {
                if (mas[i] > MAX)
                {
                    MAX = mas[i];
                }
                if (mas[i] < MIN)
                {
                    MIN = mas[i];
                }
            }

            saMAXandMIN = 1.0f * (MAX + MIN) / 2;

            //Вывод сред.арифметического всех чисел, срд.арифметического Макс. и Мин. чисел, всех чисел больших чем срд.арифметического Макс. и Мин. чисел.

            Console.WriteLine(string.Format("{0:0.000000}", saMAXandMIN));
            Console.WriteLine(string.Format("{0:0.000000}", sa));
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > saMAXandMIN)
                    Console.Write(mas[i] + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
