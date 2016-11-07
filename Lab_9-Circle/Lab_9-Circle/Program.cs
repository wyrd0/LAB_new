using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt for radius
            Console.WriteLine("Welcome to the Circle App.\n");
            Console.Write("To create a circle, please enter a radius:   ");
            double radius = IsDouble(GetInput());
            
            //call CircleApp to calculate Circumference Area
            CircleApp circle = new CircleApp(radius);
            string circumference = circle.GetFormattedCircumference(radius);
            Console.WriteLine("The circumference of your circle is {0}.", circumference);
            string area = circle.GetFormattedArea(radius);
            Console.WriteLine("The circumference of your circle is {0}.", area);
        }
        private static string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        static double IsDouble(string input)
        {
            double radius;
            bool validDouble = true;
            validDouble = double.TryParse(input, out radius);
            while (validDouble == false || radius < 1)
            {
                Console.Write("Invalid input.  Please try again.   ");
                radius = IsDouble(GetInput());
            }
            return radius;
        }
    }
}
