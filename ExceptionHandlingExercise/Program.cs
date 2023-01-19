using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            char[] arr = new char[9];
            arr[0] = '0';
            arr[1] = '1';
            arr[2] = '2';
            arr[3] = '3';
            arr[4] = '4';
            arr[5] = '5';
            arr[6] = 'a';
            arr[7] = 'b';
            arr[8] = 'c';

            List<int> numbers = new List<int>();

            string str = "";
            #region
            //foreach (var character in arr)
            //{

            //    try
            //    {

            //        int.Parse(arr);
            //    }
            //    catch 
            //    {
            //        Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
            //    }   
            //}
            #endregion

            //Console.WriteLine("...");

            //TODO START HERE:
            // Make a foreach loop to iterate through your character array
            // Now create a try catch
            foreach (char character in arr)
            {
                try
                {
                    // Inside your try block
                    // set your string variable to each array element in your char[] to .ToString()
                    str = character.ToString();
                    // Now, using int.Parse, parse your string variable and store in an int variable
                    int num = int.Parse(str);
                    // Then add each int to your list
                    numbers.Add(num);
                }
                catch (Exception ex) 
                { 

                    // catch your Exception:
                    // in the scope of your catch you can use the following, 

                    Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType());
                    Console.WriteLine();
                }
            }


            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
