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
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
                int[] MyArray = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50 - done
            Populater(MyArray);
            //Console.WriteLine($"my numbers are: ");
            //foreach (int i in MyArray)
            //    Console.WriteLine(i);   
            //TODO: Print the first number of the array
            Console.WriteLine("first number of the array: " + MyArray[0]);
                //TODO: Print the last number of the array            
            Console.WriteLine("the last number of the array: " + MyArray[49]);
                Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(MyArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(MyArray);
            Console.WriteLine("All Numbers Reversed:");
            printArray(MyArray);
            static void printArray(int[] array)
            {
                foreach (int i in array) 
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            Console.WriteLine("Multiple of three = 0: ");
            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            SetMultiplesOfThreeToZero(MyArray);
            printArray(MyArray);

            static void SetMultiplesOfThreeToZero(int[] array) 
            {
                for (int i = 0; i < array.Length; i++) 
                {
                    if (array[i] % 3 == 0)
                    {
                        array[i] = 0;
                    }
                }
            }
            static void PrintArray(int[] array) 
            {
                for (int i = 0; i < array.Length; i++) 
                {
                    Console.WriteLine(array[i]);
                } 
            }

            
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(MyArray);
            Console.WriteLine("Sorted numbers:");
            PintArray(MyArray);
            static void PintArray(int[] array)
            {
                foreach (int i in array)
                {
                    Console.WriteLine(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list = new List<int>();
            //TODO: Print the capacity of the list to the console
            Console.WriteLine(list.Capacity);
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);
            NumberPrinter(list);
            //TODO: Print the new capacity
            Console.WriteLine("new capacity:");
            Console.WriteLine(list.Capacity);
            Console.WriteLine();
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            
            
            Console.WriteLine("What number will you search for in the number list?");
            int NumbersLookingFor = int.Parse(Console.ReadLine());
            NumberChecker(list, NumbersLookingFor);
            
            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(list);
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        //private static void ThreeKiller(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] % 3 == 0)
        //        {
        //            numbers[i] = 0;
        //        }
        //    }
        //}

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count-1; i >= 0; i--) 
            {
                if (numberList[i] % 2 != 0) 
                {
                    numberList.Remove(numberList[i]);
                }
            } 
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
            bool foundNumber = false;
            foreach (var item in numberList) 
            {
                if (item == searchNumber)
                {
                    Console.WriteLine($"{searchNumber} is in the list");
                    foundNumber = true;
                    break;
                }
            }
            if (foundNumber == false)
                Console.WriteLine($"{searchNumber} is not in your list");
        }

        private static void Populater(List<int> numberList)
        {
            Random number = new Random();
            for (int i = 0; i < 50; i++)
            {
                
                int randomNumbers = number.Next(0, 51);
                numberList.Add(randomNumbers);
                Console.WriteLine(randomNumbers);
            }
            

        }

        private static void Populater(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 50);
            }

        }        

        private static void ReverseArray(int[] array)
        {
            
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
