using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last 4 digits of your faculty number here: ");
            int last4Digits = int.Parse(Console.ReadLine());

            double result = MyUniqueNumber(AgeAfter10Years(age), last4Digits);
            Console.WriteLine("After 10 Years you will be" + AgeAfter10Years(age) + "years old. " + "And your unique number is: " + result);

        }
        static int AgeAfter10Years(int currentAge)
        {
            int ageAfter10Years = currentAge + 10;
            return ageAfter10Years;
        }
        static double MyUniqueNumber(int AgeAfter10Years, int last4DigitsOfFacNumber)
        {
            double MyUniqueNumber =
                (AgeAfter10Years
                * last4DigitsOfFacNumber) / Math.PI;
            return MyUniqueNumber;
        }
    }
}


            

          

