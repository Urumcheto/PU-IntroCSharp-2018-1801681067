using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecartCoordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            string userValue;
            Console.WriteLine("Let's do some calculations!");

            Console.Write("Enter Xa: ");
            userValue = Console.ReadLine();
            while (double.TryParse(userValue, out double ignore) != true)
            {
                Console.Write("Enter Xa: ");
                userValue = Console.ReadLine();
            }
            double Xa = double.Parse(userValue);


            Console.Write("Enter Ya: ");
            userValue = Console.ReadLine();
            while (double.TryParse(userValue, out double ignore) != true)
            {

                Console.Write("Enter Ya: ");
                userValue = Console.ReadLine();
            }

            double Ya = double.Parse(userValue);

            Console.Write("Enter Xb: ");
            userValue = Console.ReadLine();
            while (double.TryParse(userValue, out double ignore) != true)
            {


                Console.Write("Enter Xb: ");
                userValue = Console.ReadLine();
            }

            double Xb = double.Parse(userValue);

            Console.Write("Enter Yb: ");
            userValue = Console.ReadLine();
            while (double.TryParse(userValue, out double ignore) != true)
            {

                Console.Write("Enter Yb: ");
                userValue = Console.ReadLine();
            }

            double Yb = double.Parse(userValue);

            Console.WriteLine("-----------");

            Console.WriteLine("The points have next coordinates:");
            Console.WriteLine($"Point A({Xa}, {Ya})");
            Console.WriteLine($"Point A({Xb}, {Yb})");

            Console.WriteLine("----------");

            double.distance = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2));

            Console.WriteLine($"The distance between the two points is: {distance}");
            Console.ReadKey();



        }
    }
}
