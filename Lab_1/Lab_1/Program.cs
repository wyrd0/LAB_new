using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            while(proceed == "y")
            { 
            //Get User Input
            Console.WriteLine("Welcome to the Grand Circus' Room Detail Generator!");
            Console.WriteLine("");
            Console.Write("Enter Length (in feet):  ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Width (in feet):  ");
            double width = Convert.ToDouble(Console.ReadLine());
            
            //Call calcRoom methods
            double area = calcRoomArea(length, width);
            double perimeter = calcRoomPerimeter(length, width);
            double volume = (calcRoomArea(length, width)*10);

            //Print result
            Console.WriteLine("");
            Console.WriteLine("_Room_Dimensions_");
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("_______________");

                //Proceed?
                Console.Write("Calculate dimensions of another room? (y/n)");
                proceed = (Console.ReadLine().ToLower());
                if (proceed == "yes")
                {
                    proceed = "y";
                }
            }

        }
        //methods
        static double calcRoomArea(double length, double width)
        {
            double area = (length * width);
            return area;
        }
        static double calcRoomPerimeter(double length, double width)
        {
            double perimeter = (2 * length + 2 * width);
            return perimeter;
        }
    }
}
