using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzClientAdvanced
{
    /// <summary>
    /// Write a program that demonstrates advanced usage of SuperFizz that performs:
    ///     Print the numbers from -12 to 145
    ///     For multiples of 3 print "Fizz"
    ///     For multiples of 7 print "Buzz"
    ///     For multiples of 38 print "Bazz"
    ///     
    /// Solution: SolveAdvancedFizzBuzz() method
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SolveAdvancedFizzBuzz();
        }
        private static void SolveAdvancedFizzBuzz()
        {
            // Declare a dictionary and set token values for 3 and 5
            Dictionary<Int64, String> tokensDictionary = new Dictionary<Int64, String> {
                { 3, "Fizz" },
                { 7, "Buzz" },
                { 38, "Bazz" }
            };
            // Create an instance of our super class passing the data dictionary as parameter
            SuperFizzBuzz superFizzBuzz = new SuperFizzBuzz(tokensDictionary);
            // Call the method that generates the list of numbers and tokens
            List<String> output = superFizzBuzz.GetOutput(-12, 145);
            foreach (var fuzzbizz in output)
            {
                Console.WriteLine(fuzzbizz);
            }
        }
    }
}
