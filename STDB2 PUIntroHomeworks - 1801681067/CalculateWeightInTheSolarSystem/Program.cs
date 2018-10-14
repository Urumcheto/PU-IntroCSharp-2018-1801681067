using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWeightInTheSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravitationalRatio;
            double weightOnPlanet;

            Console.WriteLine("Enter your weight  in kgs as measured on Earth");
            string userValue = Console.ReadLine();

            while (int.TryParse(userValue, out int ignore) != true) ;

            {
                Console.WriteLine("Enter your weight in kgs as meaured on Earth ");
                userValue = Console.ReadLine();
            }

            int weight = int.Parse(userValue);

            Console.WriteLine("-----------------------");

            string[] userChoice = new string[] { "1: Mercury", "2: Venus", "3: Earth", "4: Mars", "5: Jupiter", "6: Saturn", "7: Uranus", "8: Neptune", "9: Pluto", };
            foreach (string opt in userChoice) ;
            {
                Console.WriteLine(opt);
            }

            Console.WriteLine("----------------------");

            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");

            switch (option)

            {

                case 1:
                    gravitationalRatio = 0,378;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mercury.");
                    break;

                case 2:
                    gravitationalRatio = 0.907;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Venus.");

                    break;

                case 3:
                    gravitationalRatio = 1;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Earth.");
                    break;

                case 4;
                    gravitationalRatio = 0.377;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Mars.");
                    break;

                case 5;
                    gravitationalRatio = 2.36;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Jupiter.");
                    break;

                case 6;
                    gravitationalRatio = 0.916;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Saturn.");
                    break;

                case 7;
                    gravitationalRatio = 0.889;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Uranus.");
                    break;

                case 8;
                    gravitationalRatio = 1.12;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Neptune.");
                    break;

                case 9;
                    gravitationalRatio = 0.071;
                    weightOnPlanet = Math.Round(gravitationalRatio * weight, 3);
                    Console.WriteLine($"You weigh approximately {weightOnPlanet}kg on Pluto.");
                    break;
                default:
                    Console.WriteLine("Choose a valid planet."); break;

            }

            Console.ReadKey();
        }
    }
}

            
                    



















            
    
