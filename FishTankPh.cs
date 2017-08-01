using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allows user to input PH level of tank
            Console.WriteLine("Enter fish tank PH level (0 - 14): ");
            double tankPH;

            //Converts user input into integer 
            string ph = Console.ReadLine();
            tankPH = double.Parse(ph);

            //if statement decides if water is neutral, alkaline, 
            //or acidic. Starts with most limiting factor.
            //Prints result to console.
            if (tankPH == 7)
            {
                Console.WriteLine("Tank is neutral.");
            }

            else if (tankPH > 7)
            {
                Console.WriteLine("Tank is alkaline.");
            }

            else
            {
                Console.WriteLine("Tank is acidic.");
            }
            
            Console.ReadKey();

        }
    }
}
