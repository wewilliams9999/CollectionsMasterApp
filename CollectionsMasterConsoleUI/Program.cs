﻿using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var numbers = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);

            //Print the first number of the array
            Console.WriteLine($"{numbers[0]}");

            //Print the last number of the array
            //Console.WriteLine($"{numbers[49]}");
            Console.WriteLine($"{numbers[numbers.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);
            

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList = new List<int>();


            //Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numList.Count}");


            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Count}");


            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
           

            int userNumber;
            bool isANumber;

            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumber = int.TryParse(Console.ReadLine(), out userNumber);
            } while (isANumber == false);

            NumberChecker(numList, userNumber);
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);
            
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var myArray = numList.ToArray();

            //Clear the list
            numList.Clear();
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0 )
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }


        private static void OddKiller(List<int> numList)
        {
            for (int i = numList.Count - 1; i >=0; i--)
            {
                if (numList[i] % 2 != 0)
                {
                    numList.RemoveAt(i);
                }
            }
            //var evens = numList.Where(x => x % 2 != 0);
            NumberPrinter(numList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes, we have the number you're looking for");
            }
            else
            {
                Console.WriteLine($"No, we don't have the number you're looking for");
            }
        }

        private static void Populater(List<int> numList)
        {
            //Populate the List with 50 random numbers
            //between 0 and 50 you will need a method for this  
            //for (int i = 0; i<51; i++)
            //{
            //    numberList.Add(i);
            //}
            while (numList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numList.Add(number);
            }
             NumberPrinter(numList);
        }

        private static void Populater(int[] numbers)
        {
            //Create a method to populate the number array with
            //50 random numbers that are between 0 and 50
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }

             NumberPrinter(numbers);

        }        

        private static void ReverseArray(int[] array)
        {
            //Reverse the contents of the array and then print the array out to the console
            Array.Reverse(array);

            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
