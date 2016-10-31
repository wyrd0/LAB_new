﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine("(igpay atinlay anslatortray)\n");
        
            //set up/introduce continue loop 
            string proceed = "yes";
            while (proceed == "yes")
            {
                //Get user input
                Console.WriteLine("Please enter a word:  ");
                string word = (Console.ReadLine());
                word = word.Trim().ToLower();
                int IndexOfFirstVowel = findIndexFirstVowel(word);

                //if word starts with a vowel (append 'way')
                if (IndexOfFirstVowel == 0)
                {
                    string addWay = (word + "way");
                    Console.WriteLine(addWay);
                }
                //if word starts with a consonant (move substring before 1st vowel to end, add 'ay')
                else
                {
                    string end = word.Substring(IndexOfFirstVowel);
                    string beginning = word.Substring(0, IndexOfFirstVowel);
                    Console.WriteLine(end + beginning + "ay");
                }
                Console.Write("Translate another word? (y/n)   ");
                proceed = Proceed(Console.ReadLine());
            }
        }

        //METHODS
        //Method: Find First Vowel in word                
        private static int findIndexFirstVowel(string word)
        {
            char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
            int indexFirstVowel = word.IndexOfAny(vowel);        //find index of first vowel
            return indexFirstVowel;
        }
        //Method: Continue?
        private static string Proceed(string input)
        {
            string proceed = (input.ToLower().Trim());
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

        //private static string tryParse(string input)
        //{
        //    string msg = "Please enter a word. (Numbers and special chararcters are not allowed.)";
        //    if (string.IsNullOrEmpty(input != )
        //    {
        //        throw new Exception(msg);
        //    }

        //}

        //Next: Add validation and methods!
        //NOTES:  words with only 'y' as a vowel (e.g., shy, my) throw exception.  fix.
        // Next, (Extend) Keep case.
    }

    //validate string input
    //static bool isWord(string v)
    //{
    //    string input; 
    //    if()



    //}
}