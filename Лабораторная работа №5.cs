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
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Input Matrix ***");

            
            int[,] arr = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int MAX = 0;
            int MIN = 100000;

            //Вычисление Максимального и минимального элементов

            Console.WriteLine("*** Max and min elements ***");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] > MAX)
                    {
                        MAX = arr[i, j];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] < MIN)
                    {
                        MIN = arr[i, j];
                    }
                }
            }
      
            //Вывод сред.арифметического всех чисел, срд.арифметического Макс. и Мин. чисел

            Console.WriteLine(string.Format("{0:0.000000}", MAX));
            Console.WriteLine(string.Format("{0:0.000000}", MIN));

            //Вывод модифицированной матрицы в которой все элементы, меньшие чем 100 заменены на -, а оставшиеся на +

            Console.WriteLine("*** Modifed Matrix ***");
            float men = 100;
            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] < men)
                    {
                        Console.Write("- ");
                    }
                    if (arr [i, j] >= men)
                    {
                        Console.Write("+ ");
                    }
                }
                Console.WriteLine();
            }
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
