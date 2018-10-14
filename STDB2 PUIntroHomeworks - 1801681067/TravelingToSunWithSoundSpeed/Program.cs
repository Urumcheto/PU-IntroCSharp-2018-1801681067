using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingToSunWithSoundSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const double speedOfSound = 1234.8;
            const int distance = 14960000;
            double timeNeeded = Math.Round(distance / speedOfSound);

            Console.WriteLine($"The time needed to travel from the Earth to the sun is {timeNeeded} hours, or {Math.Round(Math.Floor(timeNeeded / 24 / 365))} years and {Math.Round((timeNeeded / 24) % 365)} days");
            Console.ReadKey();
          
        }
    }
}
