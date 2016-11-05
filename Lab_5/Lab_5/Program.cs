using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\nWelcome to the Grand Circus Casino!  Roll the dice? (y/n):   ");
            string proceed = Program.Proceed(GetInput());
            while (proceed == "yes")
            {
                
                Console.Write("\nHow many sides should each die have?   ");
                int sides =  SidesIsNumber(Console.ReadLine());
                
                //int sides = Convert.ToInt32(Console.ReadLine());
                //bool sidesOK = int.TryParse(Console.ReadLine(), out sides);
                Console.WriteLine("Rolling 2 " + sides + "-sided dice...");

                Random r = new Random();
                int die1 = r.Next(1, sides + 1);
                int die2 = r.Next(1, sides + 1);

                Console.WriteLine("You rolled a " + die1 + " and a " + die2 + ".");
                Console.Write("Would you like to roll again? (y/n)  ");
                proceed = Proceed(Console.ReadLine());

            }


        }
        private static string GetInput()
        {
            string input = Console.ReadLine();
            return input;
        }
        //private static string Proceed(string input)
        //{
        //    string proceed = (input.ToLower().Trim());
        //    if (proceed == "y" || proceed == "yes" || proceed == "sure" || proceed == "ok" || proceed == "eys")
        //    {
        //        proceed = "yes";
        //    }
        //    else if (proceed == "no" || proceed == "n")
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Goodbye! Thanks for playing!");
        //        Console.WriteLine("");
        //    }
        //    else {
        //        Console.WriteLine("Your response was not understood.  Please respond with 'y' or 'n'.");
        //        Console.WriteLine("Would you like to roll again? (y/n):  ");
        //        proceed = Console.ReadLine();
        //    }
        //    return proceed;
        //}
        private static string Proceed(string input)
        {
            string proceed = (input.ToLower().Trim());
            switch (proceed)
            {
                case "y":
                case "eys":
                case "yes":
                case "ok":
                case "sure":
                    proceed = "yes";
                    break;
                case "no":
                case "n":
                    proceed = "no";
                    Console.WriteLine("\nGoodbye! Thanks for playing!\n");
                    break;
                default:
                    Console.Write("Your response was not understood.  Please respond with 'y' or 'n'.");
                    proceed = Proceed(GetInput());
                    break;
            }
            return proceed;
        }
        private static int SidesIsNumber(string input)
        {
            int sides = 1;

            bool sidesOK = sidesOK = int.TryParse(input, out sides); 
            while (sidesOK == false || sides < 1)
            {
              Console.Write("A die cannot have  " + input + "  sides.  Please try again.   ");
                sides = SidesIsNumber(GetInput());
                break;
            }
            return sides;
        }
    }
}
