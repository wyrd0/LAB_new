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

            //get input
            Console.Write("Enter an integer:  ");
            double input = Convert.ToInt32(Console.ReadLine());

            ////square and cube input
            //double square = (Math.Pow(input, 2));
            //double cube = (Math.Pow(input, 3));

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
        }
    }
}
