using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Learn you squares and cubes!");
            Console.WriteLine(" ");

            string proceed = "y";
            while (proceed == "y")
            {
                //get input
                Console.Write("Enter an integer:  ");
                int input = Convert.ToInt32(Console.ReadLine());

                //display output with padding
                Console.WriteLine(" ");
                Console.WriteLine("Number".PadRight(15) + "Squared".PadRight(15) + "Cubed".PadRight(15));
                Console.WriteLine("=======".PadRight(15) + "=======".PadRight(15) + "=======".PadRight(15));

                //set up for loop
                int i = 1;
                for (i = 1; i <= input; i++)
                {
                    double square = (Math.Pow(i, 2));
                    double cube = (Math.Pow(i, 3));
                    Console.WriteLine(i + "".PadRight(14) + square + "".PadRight(14) + cube + "".PadRight(14));
                }
                //Proceed?
                Console.WriteLine("");
                Console.Write("Continue? (y/n)");
                proceed = (Console.ReadLine().ToLower());
                if (proceed == "yes" || proceed == "y")
                {
                    proceed = "y";
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }

    }


}
