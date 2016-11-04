using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup, input
            Console.WriteLine("Welcome to the Batting Average Calculater!\n");

            int numHitters = GetInput("Enter number of hitters:  ");
            int atBat = GetInput("Enter the number of times at bat:   ");

            //create arrays
            double[,] allStats = new double[numHitters, 2];
            int[] battingResults = new int[atBat];

            //get result for hitter (--> array battingResults)
            Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=homerun");

            int n = 0;
            do
            {
                n++;
                for (int i = 0; i < atBat; i++)
                {
                    Console.Write("Enter at bat results for Hitter " + (n) + " :  ");
                    battingResults[i] = int.Parse(Console.ReadLine());
                }

            } while (n < numHitters);

            // count hits and sum bases in battingResults
            double battingAve = 0;
            double sluggingAve = 0;

            
            int sumBases = 0;
            int sumHits = 0;
            for (int i = 0; i < battingResults.Length; i++)
            {
                sumBases += battingResults[i];  //creating values for hits from array
                sumHits += battingResults[i] >= 1 ? 1 : 0; // add 1 or 0, depending on nonzero
            }

            //calculate aves
            battingAve = (double)sumHits / atBat;
            sluggingAve = (double)sumBases / atBat;

            battingAve = Math.Round(battingAve, 3);
            sluggingAve = Math.Round(sluggingAve, 3);

            //populate 2D array with battingAve and sluggingAve for each hitter
            Console.WriteLine("BattingAve \tSluggingAve");
            for (int i = 0; i < numHitters; i++)
            {
                allStats[i, allStats.Length -  = battingAve;
                allStats[i, 1] = sluggingAve;

                Console.WriteLine(allStats[i, i] + " \t" + allStats[i, i]);
            }

            //OUTPUT
            // Console.WriteLine("Batting Average:  " + battingAve);
            //Console.WriteLine("Slugging Average:  " + sluggingAve);

        }//Main

        ////       private static void StatCrunch(out double battingAve, out double sluggingAve)
        //      {




        //       }

        //METHOD Get input
        private static int GetInput(string message)
        {
            int input;
            Console.Write(message);

            input = int.Parse(Console.ReadLine());
            return input;
        }

        //METHOD BattingAverage(nAtBats/nAtBatsW>=1Hit)
        //static double BattingAverage()
        //{

        //}

        ////METHOD  Slugging Percentage (Sum Hits/nAtBat)
        //static double SluggingPercentage()
        //{

        //}
        ////Print 2DArray
        //for (int Row = 0; Row < atBat; Row++)
        //{
        //    Console.WriteLine("+ 1);

        //    for (int Column = 0; Column < NumberOfGrades; Column++)
        //    {
        //        Console.Write("Please enter grade {0}: ", Column + 1);
        //        StudentGrades[Row, Column] = int.Parse(Console.ReadLine());


        //int sumHits = outcomes.Sum();
        //int atBatsWHit = outcomes.Count( > 0> );
        //double battingAve = (atBat/
        //double sluggingAve =
    }
}
