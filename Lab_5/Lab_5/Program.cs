﻿using System;
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
            string proceed = Program.Proceed(Console.ReadLine());
            Console.Write("\nHow many sides should the die have?   ");
            int sides = Convert.ToInt32(Console.ReadLine());

            Console.Write ( &#9856);
        }
        //static int roll2Dice(int sides)
        //{
            

        //}
        private static string Proceed(string v)
        {
            string proceed = (v.ToLower().Trim());
            if (proceed == "y" || proceed == "yes" || proceed == "sure" || proceed == "ok")
            {
                proceed = "yes";
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Goodbye!");
                Console.WriteLine("");
            }
            return proceed;
        }
        }

}
