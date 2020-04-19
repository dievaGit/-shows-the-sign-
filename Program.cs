using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            float a = 0.0f, b = 0.0f, c = 0.0f;

            //Requesting data from the user
            Console.Write(" Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the second number: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (((a > 0) && (b > 0) && (c > 0)) || ((a < 0) && (b < 0) && (c > 0)) || ((a > 0) && (b < 0) && (c < 0)) || ((a < 0) && (b > 0) && (c < 0)))
            {
                Console.Write(" The result is positive.");
            }
            else
            {
                Console.Write(" The result is negative.");
            }

            Console.ReadKey();
        
        }
    }
}
