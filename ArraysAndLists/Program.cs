using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray1 = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evensList = new List<int>();  // var evensList = new List<int>();

            List<int> oddsList = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (var i = 0; i < 10; i++) // another way to do it: for (var i = 0; < numbers.Legenth; i)
            {
                if (i % 2 == 0) // if(numbers[i] % 2 == 0))

                {
                    evensList.Add(i); //evens.Add(numbers[i]);
                }
                else
                {
                    oddsList.Add(i); //odds.Add(numbers[i]);
                }
            }

                



                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */
                foreach (var num in evensList)  // foreach (var even in evensList)
                {
                    Console.WriteLine(num); // Console.WriteLine($"{evenNum} is an even number.");
                }
                Console.WriteLine();
                Console.WriteLine(evensList.Count);

            Console.WriteLine();

                foreach (var num in oddsList)
                {
                    Console.WriteLine(num);
                }
                Console.WriteLine();
                Console.WriteLine(oddsList.Count);
              
            
              

        }
    }
}


