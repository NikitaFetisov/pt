using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace lr11
{
    enum Categorys
    {
        Track,
        Plane,
        Ship
    }
    class Person
    {
        public String Target_ID { get; set; }
        public float Param1 { get; set; }
        public float Param2 { get; set; }
        public float Param3 { get; set; }
        public Categorys Category { get; set; }
        public Boolean HasWeapon { get; set; }

        public Person() { }
        public Person(String str)
        {
            string[] elems = str.Split(',');

            Target_ID = elems[0].Trim();
            Param1 = Convert.ToInt32(elems[1]);
            Param2 = Convert.ToSingle(elems[3].TrimStart(',').Replace('.', ','));
            Param3 = Convert.ToSingle(elems[3].TrimStart(',').Replace('.', ','));
            //Convert.ToSingle(elems[3].TrimStart('$').Replace('.', ','));
            switch (elems[4].Trim())
            {
                case "Track": Category = Categorys.Track; break;
                case "Plane": Category = Categorys.Plane; break;
                case "Ship": Category = Categorys.Ship; break;
            }
            HasWeapon = Convert.ToBoolean(elems[5].Trim());
        }

        public string CategoryToString(Categorys dep)
        {
            switch (dep)
            {
                case Categorys.Track: return "Track";
                case Categorys.Plane: return "Plane";
                case Categorys.Ship: return "Ship";

                default: return null;
            }
        }
        public string HasWeaponToString(Boolean a)
        {
            if (a) return "yes";
            else return "no";
        }
        public override string ToString()
        {
            String str = string.Format(
                "---------------------------------------------------------------------------\n" +
                "PersonID: {0}, Param1: {1}, Param2: {2:0.00}, Param3: {3:0.00}, Category: {4},\n" +
                "Weapon: {7}",
                Target_ID, Param1, Param2, Param3, CategoryToString(Category), HasWeaponToString(HasWeapon));
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            StreamReader f_in = new StreamReader("lr11_06.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"output.txt");
            Console.SetOut(new_out);
#endif
            List<Person> all = new List<Person>();

            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                    all.Add(new Person(line));
            }
            catch (Exception e) { Console.Error.WriteLine(e.Message); }

            /*foreach (var p in all)
                Console.WriteLine(p);*/

            // Задание 3
            int HasWeapons = 0, hasntWeapons = 0;
            foreach (var p in all)
                if (p.HasWeapon == true) ++HasWeapons;
                else ++hasntWeapons;

            // Задание 2
            float avgParam1Track, avgParam1Plane, avgParam1Ship;
            float totalParam1Track = 0, totalParam1Ship = 0, totalParam1Plane = 0;
            float personsTrack = 0, personsPlane = 0, personsShip = 0;
            foreach (var p in all)
            {
                switch (p.Category)
                {
                    case Categorys.Track:
                        {
                            ++personsTrack;
                            totalParam1Track += p.Param1;
                            break;
                        }
                    case Categorys.Plane:
                        {
                            ++personsPlane;
                            totalParam1Plane += p.Param1;
                            break;
                        }
                    case Categorys.Ship:
                        {
                            ++personsShip;
                            totalParam1Ship += p.Param1;
                            break;
                        }
                    default:
                        break;
                }
            }
            avgParam1Track = totalParam1Track / (float)personsTrack;
            avgParam1Ship = totalParam1Ship / (float)personsShip;
            avgParam1Plane = totalParam1Plane / (float)personsPlane;


            // Задание 3
            float sumParam2Track, sumParam2Plane, sumParam2Ship;
            float totalParam2Track = 0, totalParam2Ship = 0, totalParam2Plane = 0;
            foreach (var p in all)
            {
                switch (p.Category)
                {
                    case Categorys.Track:
                        {
                            totalParam2Track += p.Param2;
                            break;
                        }
                    case Categorys.Plane:
                        {
                            totalParam2Plane += p.Param2;
                            break;
                        }
                    case Categorys.Ship:
                        {
                            totalParam2Ship += p.Param2;
                            break;
                        }
                    default:
                        break;
                }
            }
            sumParam2Track = (float)totalParam2Track;
            sumParam2Ship = (float)totalParam2Ship;
            sumParam2Plane = (float)totalParam2Plane;

            // Задание 4
            float maxParam1 = 0;
            int kolvoMaxParam1 = 0;
            foreach (var p in all)
            {
                if (p.Param1 > maxParam1)
                {
                    maxParam1 = p.Param1;
                }
            }
            foreach (var p in all)
            {
                if (p.Param1 == maxParam1)
                {
                    kolvoMaxParam1++;
                }
            }


                // Общий вывод
                Console.WriteLine("Zadanie 1");
            Console.WriteLine("Среднee значение Param1 по категории Track: {0}\n" +
                "Среднee значение Param1 по категории Plane: {1}\n" +
                "Среднe значение Param1 по категории Ship: {2}\n",
                Convert.ToString(avgParam1Track), Convert.ToString(avgParam1Plane),
                Convert.ToString(avgParam1Ship));

            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Средняя сумма параметров Param2 по категории Track: {0}\n" +
                "Среднee сумма параметров Param2 по категории Plane: {1}\n" +
                "Среднe сумма параметров Param2 по категории Ship: {2}\n",
                Convert.ToString(sumParam2Track), Convert.ToString(sumParam2Plane),
                Convert.ToString(sumParam2Ship));

            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Количество сотрудников с оружием: " + Convert.ToString(HasWeapons));
            Console.WriteLine("Количество сотрудников без оружия: " + Convert.ToString(hasntWeapons));

            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Количество объектов с максимальным значением Param1: {0}", kolvoMaxParam1);
            Console.WriteLine("{0}", Convert.ToString(maxParam1));
#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#else
            Console.ReadKey();
#endif
        }
    }
}