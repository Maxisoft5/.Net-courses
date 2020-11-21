using System;
using System.Linq;
using StructTask.Models;
using static System.Console;
namespace StructTask
{
    class Program
    {
        static private void Validation()
        {
            WriteLine("Enter first name");
            string firstName = ReadLine();
            WriteLine("Enter last name");
            string lastName = ReadLine();
            WriteLine("Enter your age");
            int age = int.Parse(ReadLine());
            var user = new Person(firstName, lastName, age);
            WriteLine(user.ValidateAge(18));
        }
        static private Reactangle Create()
        {
            WriteLine("1 - Enter width and height to create a reactangle; 2 - Enter four x and y coordinates to create a reactagne");
            int choose = int.Parse(ReadLine());
            Reactangle reactangle;
            switch (choose)
            {
                case 1:
                    WriteLine("Enter a width of reactangle");
                    double width = double.Parse(ReadLine());
                    WriteLine("Enter a height of reactangle");
                    double height = double.Parse(ReadLine());
                    reactangle = new Reactangle(width, height);
                    return reactangle;

                case 2:
                    double[] coordinatesX = new double[4];
                    double[] coordinatesY = new double[4];
                    WriteLine("Enter four x and y coordinates");
                    for (int i = 0; i < 4; i++)
                    {
                        WriteLine("Enter four x coordinate");
                        double xCoord = double.Parse(ReadLine());
                        coordinatesX[i] = xCoord;
                        WriteLine("Enter four y coordinates");
                        double yCoord = double.Parse(ReadLine());
                        coordinatesY[i] = yCoord;
                    }
                    reactangle = new Reactangle(coordinatesX, coordinatesY);
                    return reactangle;

                default:
                    throw new ArgumentException("Wrong input");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("1 - To validate your age; 2 - To create a new reactangle");
                int choose = int.Parse(ReadLine());
                switch (choose)
                {
                    case 1:
                        Validation();
                        break;
                    case 2:
                        var reactagnle = Create();
                        WriteLine($"Your reactangle' height:{reactagnle.Height}, width:{reactagnle.Width}, perimeter:{reactagnle.Perimeter()}");
                        break;
                }
            }

        }
    }
}
