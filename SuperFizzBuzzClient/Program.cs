using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzClient
{
    /// <summary>
    /// A more generic client application to test other functionalities that are not listed in the coding exercise document,
    /// feel free to skip this as I created it merely for personal purposes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayUserDefinedTokenValues();            
        }
        /// <summary>
        /// Maybe a user wants to test division by 4, 13 and 9 using "Frog", "Duck" and "Chicken" respectively, 
        /// in this case 52 would output "FrogDuck", 36 would output "FrogChicken" and 468 would output "FrogDuckChicken".
        /// 
        /// Solution: Since we want to avoid displaying a huge list of numbers like from 36 to 468 just to test these 3 values, 
        /// let's define a set of integers not necessarily in order and pass it in as a parameter, SuperFizzBuzz should be intelligent enough
        /// to handle it... in theory =o)
        /// </summary>
        private static void DisplayUserDefinedTokenValues()
        {
            // Declare a dictionary and set token values for 3 and 5
            Dictionary<Int64, String> tokensDictionary = new Dictionary<Int64, String> {
                { 4, "Frog" },
                { 13, "Duck" },
                { 9, "Chicken" }
            };
            // Create an instance of our super class passing the data dictionary as parameter
            SuperFizzBuzz superFizzBuzz = new SuperFizzBuzz(tokensDictionary);
            // Call the method that generates the list of numbers and tokens
            List<String> output = superFizzBuzz.GetOutput( new long[] { 9, 4, 12, 13, 14, 35, 36, 400, 500, 468 } );
            foreach (var fuzzbizz in output)
            {
                Console.WriteLine(fuzzbizz);
            }
        }
    }
}
