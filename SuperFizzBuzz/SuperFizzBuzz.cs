using System;
using System.Collections.Generic;

namespace SuperFizzBuzzLibrary
{
    /// <summary>
    /// SupperFizzBuzz class can be seen as a translator, you will tell what to say whenever it finds a number that
    /// is multiple of another or a set of numbers; taking basic FuzzBizz as example:
    ///     3 -> Fizz, 5 -> Buzz, 3 and 5 -> FizzBuzz
    /// 
    /// Input data dictionary would look like:        
    ///     Dictionary<Int64, String> tokensDictionary = new Dictionary<Int64, String>();
    /// 
    /// And the the list of tokens you want to use; 3 and 5 in this case:
    ///     tokensDictionary.Add(3, "Fizz");
    ///     tokensDictionary.Add(5, "Buzz");
    /// 
    /// </summary>
    public class SuperFizzBuzz
    {
        /// <summary>
        /// The list of numbers to translate
        /// </summary>
        private Dictionary<Int64,String> Tokens { get; set; } 
        /// <summary>
        /// The final output once it has been translated
        /// </summary>
        private List<String> Output = new List<String>();
        /// <summary>
        /// Create a class instance and set the data dictionary which indicates what numbers are going to be the multiples 
        /// and what output token will produce them
        /// </summary>
        /// <param name="tokens">A data dictionary</param>
        public SuperFizzBuzz(Dictionary<Int64,String> tokens)
        {
            Tokens = tokens;            
        }
        /// <summary>
        /// User can define a range of numbers e.g. from 2 to 35 or from 1 to 1000000 or even negative numbers from -10 to 35
        /// </summary>
        /// <param name="from">Initial number</param>
        /// <param name="to">End number</param>
        /// <returns></returns>
        public List<String> GetOutput(long from, long to)
        {
            FeedOutputFromRange(from, to);
            return Output;
        }
        /// <summary>
        /// User can define a set of numbers not necessarily in sequential order
        /// </summary>
        /// <param name="input">A set of numbers, no matter if they are not in sequential order e.g. [10,9,8,15,1,2,7,13]</param>
        /// <returns></returns>
        public List<String> GetOutput(long[] input)
        {
            FeedOutputFromSet(input);
            return Output;
        }
        /// <summary>
        /// Take a number as input, perform a modulo operation against all elements in the data dictionary.
        ///     data dictionary = { 3:Fuzz, 7:Bizz, 38:Bazz }
        ///     case input = 1, output = 1
        ///     case input = 3, output = Fuzz
        ///     case input = 21, output = FuzzBizz because 21 % 3 = 0 and 21 % 7 = 0
        /// </summary>
        /// <param name="id">The number to evaluate against all elements in dictionary</param>
        /// <returns>Either default number or the token defined in dictionary</returns>
        private string GetToken(long id)
        {
            // No need to evaluate zero
            if (id == 0) return id.ToString();

            String output = null;            
            // Iterate over the dictionary to build an output string
            foreach( var token in Tokens )
            {                
                if ( Math.Abs(id) % Math.Abs(token.Key) == 0 )  
                {
                    output += token.Value;                    
                }
            }            
            // If the id is not present, then return id
            if (output == null)
                output = id.ToString();

            return output;
        }
        private void FeedOutputFromRange(long from, long to)
        {            
            // should we go from left to right ?
            if (from <= to)
            {
                while (from <= to)
                {                    
                    Output.Add( GetToken(from));
                    from++;
                }
            }
            else // or right to left ?
            {
                while (from >= to)
                {                    
                    Output.Add(GetToken(from));
                    from--;
                }
            }
        }
        private void FeedOutputFromSet(long[] input)
        {            
            foreach(var current in input)
            {                
                Output.Add(GetToken(current));
            }
        }
    }
}
