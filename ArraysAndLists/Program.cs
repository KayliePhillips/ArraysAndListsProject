using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // DONE Create an int Array and populate numbers 1-10
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* DONE Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            //can write either way

            //var even = new List<int>();
            //var odds = new List<int>();
            
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (int num in myArray)
            {
                if (num%2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }


            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.Write($"This is the entire list of numbers: ");
            foreach (int num in myArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"These are the even numbers from the list: ");
            foreach (int num in evens)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write($"These are the odd numbers from the list: ");
            foreach (int num in odds)
            {
                Console.Write($"{num} ");
            }
            
        }
    }
}
