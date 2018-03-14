using SuperFizzBuzzLibrary;
using System;
using System.Collections.Generic;

namespace SuperFizzBuzzClientBasic
{
    /// <summary>
    /// Write a console application, using your SuperFizzBuzz class to solve the classic FizzBuzz problem:
    ///     Print the numbers from 1 to 100. 
    ///     For multiples of 3 print "Fizz" instead of the number
    ///     For multiples of 5 print "Buzz" instead of the number
    ///     For multiples of 3 and 5 print "FizzBuzz" instead of the number
    ///     
    /// Solution: SolveClassicFizzBuzz() method
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SolveClassicFizzBuzz();
        }
        private static void SolveClassicFizzBuzz()
        {
            // Declare a dictionary and set token values for 3 and 5
            Dictionary<Int64, String> tokensDictionary = new Dictionary<Int64, String> {
                { 3,"Fizz"},
                { 5,"Buzz"}
            };
            // Create an instance of our super class passing the data dictionary as parameter
            SuperFizzBuzz superFizzBuzz = new SuperFizzBuzz(tokensDictionary);
            // Call the method that generates the list of numbers and tokens
            List<String> output = superFizzBuzz.GetOutput(1, 100);            
            foreach (var fuzzbizz in output)
            {
                Console.WriteLine(fuzzbizz);
            }
        }
    }    
}
