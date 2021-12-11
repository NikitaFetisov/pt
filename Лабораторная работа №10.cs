using System;
using System.IO;


namespace Лаба4
{
    class Matrix
    {
        private float[,] matrix1;
        private float[,] matrix2;
        private float[,] SumaMatrix;
        int m, n;

        //Конструктор
        public Matrix()
        {

        }

        //Генерация 1 матрицы заданного размера
        public void GenerateMatrix1(int M, int N)
        {
            m = M;
            n = N;
            Random r = new Random(DateTime.Now.Millisecond);

            matrix1 = new float[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix1[i, j] = (float)r.Next(1000);
                }
            }
        }

        //Сохранение 1 сгенерированной матрицы в файл
        public void SaveMatrix1(string pFileName)
        {
            if (matrix1.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix1[i, j].ToString("E10"));
                tw.Close();
            }
        }

        //Загрузка 1 сохраненной матрицы из файла
        public bool LoadMatrix1(string pFilename)
        {
            if (File.Exists(pFilename))
            {
                try
                {
                    TextReader tr = File.OpenText(pFilename);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    matrix1 = new float[m, n];
                    string line;
                    string[] substring;

                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            matrix1[i, j] = Convert.ToSingle(substring[2]);
                        }
                    tr.Close();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        //Вывод 1 матрицы в консоль
        public void PrintMatrix1()
        {
            if (matrix1.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(matrix1[i, j].ToString("") + " ");
                    Console.WriteLine();
                }
            }
        }

        //Генерация 2 матрицы заданного размера
        public void GenerateMatrix2(int M, int N)
        {
            m = M;
            n = N;
            Random r = new Random(DateTime.Now.Millisecond);

            matrix2 = new float[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix2[i, j] = (float)r.Next(1000);
                }
            }
        }

        //Сохранение 2 сгенерированной матрицы в файл
        public void SaveMatrix2(string pFileName)
        {
            if (matrix2.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + matrix2[i, j].ToString("E10"));
                tw.Close();
            }
        }

        //Загрузка 2 сохраненной матрицы из файла
        public bool LoadMatrix2(string pFilename)
        {
            if (File.Exists(pFilename))
            {
                try
                {
                    TextReader tr = File.OpenText(pFilename);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    matrix2 = new float[m, n];
                    string line;
                    string[] substring;

                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            matrix2[i, j] = Convert.ToSingle(substring[2]);
                        }
                    tr.Close();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        //Вывод 2 матрицы в консоль
        public void PrintMatrix2()
        {
            if (matrix2.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(matrix2[i, j].ToString("") + " ");
                    Console.WriteLine();
                }
            }
        }

        //Генерация 3 матрицы заданного размера
        public void GenerateMatrix3(int M, int N)
        {
            m = M;
            n = N;
            Random r = new Random(DateTime.Now.Millisecond);

            SumaMatrix = new float[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    SumaMatrix[i, j] = (float)r.Next(1000);
                }
            }
        }

        //Сложение матриц
        public void SumMatrix()
        {
            LoadMatrix3("FileForMatrix3.txt");
            LoadMatrix1("FileFormatrix1.txt");
            LoadMatrix2("FileForMatrix2.txt");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    SumaMatrix[i, j] = matrix1[i, j] + matrix2[i,j];
                }
        }

        //Сохранение 3 сгенерированной матрицы в файл
        public void SaveMatrix3(string pFileName)
        {
            if (SumaMatrix.Length > 0)
            {
                if (File.Exists(pFileName))
                    File.Delete(pFileName);

                FileInfo f = new FileInfo(pFileName);
                TextWriter tw = f.CreateText();

                tw.WriteLine(m.ToString());
                tw.WriteLine(n.ToString());

                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                        tw.WriteLine(i.ToString() + " " + j.ToString() + " " + SumaMatrix[i, j].ToString("E10"));
                tw.Close();
            }
        }

        //Загрузка 3 сохраненной матрицы из файла
        public bool LoadMatrix3(string pFilename)
        {
            if (File.Exists(pFilename))
            {
                try
                {
                    TextReader tr = File.OpenText(pFilename);
                    m = Convert.ToInt32(tr.ReadLine());
                    n = Convert.ToInt32(tr.ReadLine());

                    SumaMatrix = new float[m, n];
                    string line;
                    string[] substring;

                    for (int i = 0; i < m; i++)
                        for (int j = 0; j < n; j++)
                        {
                            line = tr.ReadLine();
                            substring = line.Split(new char[] { ' ' }, 3);
                            SumaMatrix[i, j] = Convert.ToSingle(substring[2]);
                        }
                    tr.Close();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        //Вывод 3 матрицы в консоль
        public void PrintMatrix3()
        {
            if (SumaMatrix.Length > 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(SumaMatrix[i, j].ToString("") + " ");
                    Console.WriteLine();
                }
            }
        }
    }
    class Programm
    {
        static void Main(string[] args)
        { 
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Fetisov N.A" + "\n");

            Matrix m1 = new Matrix();
            m1.GenerateMatrix1(10, 5);
            m1.SaveMatrix1("FileForMatrix1.txt");
            if (m1.LoadMatrix1("FileForMatrix1.txt"))
                m1.PrintMatrix1();
            Console.WriteLine(" \n");

            Matrix m2 = new Matrix();
            m2.GenerateMatrix2(10, 5);
            m2.SaveMatrix2("FileForMatrix2.txt");
            if (m2.LoadMatrix2("FileForMatrix2.txt"))
                m2.PrintMatrix2();
            Console.WriteLine(" \n");

            Matrix m3 = new Matrix();
            m3.GenerateMatrix3(10, 5);
            m3.SaveMatrix3("FileForMatrix3.txt");
            if (m3.LoadMatrix3("FileForMatrix3.txt"))
                m3.SumMatrix();
                m3.PrintMatrix3();
            Console.WriteLine(" \n");

            Console.ReadKey();
        }
    }
}
