using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

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
            //TODO: Create an integer Array of size
            int[] numbers = new int[50];
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50

            //TODO: Print the first number of the array
            Populater(numbers);

            Console.WriteLine(numbers[0]);
            //TODO: Print the last number of the array
            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            
                

            Console.WriteLine("All Numbers Reversed:");
            //NumberPrinter(numbers.Reverse());
            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> ints = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine(ints.Count());

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(ints);

            //TODO: Print the new capacity
            Console.WriteLine(ints.Count());

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            int num = 0;
            bool validNumber = false;
            int searchNumber = 0;

            while(validNumber == false) 
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Not an integer. Enter another number");
                }
                else
                {
                    searchNumber = int.Parse(input);
                    validNumber = true;
                }
            }
           

            NumberChecker(ints, searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(ints);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(ints);
            NumberPrinter(ints);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            ints.Sort();
            NumberPrinter(ints);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArr = ints.ToArray();

            //TODO: Clear the list
            ints.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 3 == 0) 
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++) 
            {
                if (numberList[i] % 2 != 0 && numberList[i] != 0) 
                {
                    numberList.RemoveAt(i);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber)) 
            {
                Console.WriteLine("Number is in List");
            }

            else 
            {
                Console.WriteLine("Number is not in List");
            }
        }

        private static void Populater(List<int> numberList)
        {
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(i);
            }

        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

        }        

        private static void ReverseArray(int[] array)
        {
            int counter = 0;
            for (int i = array.Length - 1; i >= array.Length / 2; i--) 
            {
                array[counter] = array[i];
                array[i] = array[counter + 1];
                counter++;
            }  
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
