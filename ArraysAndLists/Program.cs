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
            int[] myArray1 = new int[10];

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
          List<int> evensList = new List<int>();
          List<int> oddsList = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0);
            }
            {
            evensList.Add(10);
            }
          
           for (var i = 0;i < 10;i--)
                if(i % 2 == 0)
                {
                    oddsList.Add(10);
                }
         



            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (var num in evensList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine(evensList.Count);
            Console.WriteLine(evensList[10]);
            Console.WriteLine(evensList[evensList.Count - 1]);

        }
    }
}
