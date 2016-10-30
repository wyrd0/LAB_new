using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.Write("/nEnter a number between 1 and 10, inclusive:     ");
            //long input = Convert.ToInt32(Console.ReadLine());


            //for(int i = input; i >= 1; i--)
            //{
            //    long factorial = (factorial * (factorial - 1));

            //}
            string proceed = "y";
            Console.WriteLine("\nWelcome to the Factorial Calculator!\n");

            do
            {
                //get input (long 1-10)
                Console.Write("Enter an integer that is greater than 1 and less than 10:   ");
                string input = Console.ReadLine();
                long number;
                long.TryParse(input, out number);
                
                //calculate, display factorial
                long factorial = 1;
                for (long i = 2; i <= number; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("The factorial of " + input + " is " + factorial);

                //Proceed?
                Console.WriteLine("Continue? (y/n)");
                proceed = Console.ReadLine();
            } while (proceed == "y");
            //validate

        }
    }
}
