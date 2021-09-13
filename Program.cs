using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 1");
            Console.WriteLine(" ");
            Console.WriteLine(" Выполнил: Фетисов Никита Александрович");
            Console.WriteLine(" Группа ИНС-б-о-20-2");
            Console.WriteLine(" Наименование ЛР: Структура консольного приложения ");
            Console.WriteLine("  ");
            Console.WriteLine(" вариант 25");
            Console.WriteLine(" ");
            Console.WriteLine(" Введите значения переменных rx, z и Y ");
            int rx = Convert.ToInt32(Console.ReadLine());
            var z = Convert.ToInt32(Console.ReadLine());
            var Y = Convert.ToInt32(Console.ReadLine());
            var U = rx*z+(z*Y)-((Y+z)/rx) ;
            Console.WriteLine("Ответ = " + U);
            Console.WriteLine(" ");
            Console.WriteLine(" Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
