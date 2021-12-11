using System;
using System.IO;


namespace Лаба4
{

    public class Human : ICalculate, IVisual
    {
        public Human(string pFIO, int pAge)
        {
            FIO = pFIO;
            Age = pAge;
        }
        private string FIO;
        private int Age;

        public void Plus(int pPlus)
        {
            Age += pPlus;
        }
        public void Minus(int pMinus)
        {
            Age -= pMinus;
        }

        public string Name
        {
            get
            {
                return FIO + " : " + Age.ToString();

            }
            set
            {
                FIO = value;
            }
        }
        public void DrawObject()
        {
            Console.WriteLine
                (
                "      0      \n" +
                "    -----    \n" +
                "      |      \n" +
                "     / \\    \n" +
                "    /   \\   \n"
                );
            Console.WriteLine(Name);
        }
    }
    public class Car : ICalculate, IVisual
    {
        public Car(string pManufacturer, string pModel, int pVelocity)
        {
            Manufacturer = pManufacturer;
            Model = pModel;
            Velocity = pVelocity;
        }
        private string Manufacturer;
        private string Model;
        private int Velocity;

        public void Plus(int pPlus)
        {
            Velocity += pPlus;
        }
        public void Minus(int pMinus)
        {
            Velocity -= pMinus;
        }
        public string Name
        {
            get
            {
                return Manufacturer + " - " + Model + " " + Velocity.ToString() + " km/h";
            }
            set
            {
                Model = value;
            }

        }
        public void DrawObject()
        {
            Console.WriteLine
                (
                "       -------\n" +
                "______/       \\_____\n" +
                "|                    |\n" +
                "--(@)---------(@)----\n"
                );
            Console.WriteLine(Name);
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.Title = "Лабораторная работ №9 Fetisov.N.A";

            Human h = new Human("Фетисов Никита", 19);
            h.Plus(20);
            h.Minus(20);
            h.DrawObject();

            Console.WriteLine("\n\n\n");

            Car car = new Car("Audi", "a30", 120);
            car.Plus(25);
            car.Minus(25);
            car.DrawObject();

            Console.ReadKey();
        }
    }
}
    






internal interface IVisual
    {
    }

    public interface ICalculate
    {
    } 
    
