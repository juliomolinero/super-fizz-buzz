using NUnit.Framework;
using System;
using System.Collections.Generic;
using SuperFizzBuzzLibrary;

namespace SuperFizzBuzzLibraryTests
{
    [TestFixture]
    public class SuperFizzBuzzTests
    {
        // ================================================================
        // The ones needed for "basics" tests
        // ================================================================
        private Dictionary<Int64, String> fizzBuzzClassicDict = new Dictionary<Int64, String> {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };        
        private SuperFizzBuzz fizzBuzzClassic;
        // ================================================================
        // The ones needed for "advanced" tests
        // ================================================================
        private Dictionary<Int64, String> fizzBuzzAdvancedDict = new Dictionary<Int64, String> {
            { 4, "Frog" },
            { 13, "Duck" },
            { 9, "Chicken" }
        };
        SuperFizzBuzz superFizzBuzzAdvanced;
        // ================================================================
        // Create instances for "basics" and "advanced" tests
        // ================================================================
        [SetUp]
        public void SetUp()
        {
            fizzBuzzClassic = new SuperFizzBuzz(fizzBuzzClassicDict);
            superFizzBuzzAdvanced = new SuperFizzBuzz(fizzBuzzAdvancedDict);
        }
        // ================================================================

        #region FizzBuzz Classic Tests
        [Test]
        public void SuperFizzBuzz_WhenDefault_Returns_Input()
        {
            // Arrange            
            long[] input = new long[] { 1,2,4,7,8,13,14,16,22 };
            // expected results as strings
            List<String> expectedOutput = new List<string>();
            foreach( var element in input)
            {
                expectedOutput.Add(element.ToString());
            }
            // Act
            List<String> output = fizzBuzzClassic.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod3_Returns_Fizz()
        {
            // Arrange            
            long[] input = new long[] { 3,6,9,12,18 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "Fizz", "Fizz", "Fizz", "Fizz", "Fizz" };            

            // Act
            List<String> output = fizzBuzzClassic.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod5_Returns_Buzz()
        {
            // Arrange            
            long[] input = new long[] { 5, 10, 20, 25 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "Buzz", "Buzz", "Buzz", "Buzz" };

            // Act
            List<String> output = fizzBuzzClassic.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod3AndMod5_Return_FizzBuzz()
        {
            // Arrange            
            long[] input = new long[] { 15,30,45,60 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "FizzBuzz", "FizzBuzz", "FizzBuzz", "FizzBuzz" };

            // Act
            List<String> output = fizzBuzzClassic.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));

        }
        #endregion FizzBuzz Classic Tests - End
        #region Advanced Tests        

        [Test]
        public void SuperFizzBuzz_WhenMod4_Returns_Frog()
        {
            // Arrange            
            long[] input = new long[] { 4, 8, 12, 16, 20 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "Frog", "Frog", "Frog", "Frog", "Frog" };

            // Act
            List<String> output = superFizzBuzzAdvanced.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod13_Returns_Duck()
        {
            // Arrange            
            long[] input = new long[] { 13,26,39 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "Duck", "Duck", "Duck" };

            // Act
            List<String> output = superFizzBuzzAdvanced.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod4AndMod13_Return_FrogDuck()
        {
            // Arrange            
            long[] input = new long[] { 52,104,156 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "FrogDuck", "FrogDuck", "FrogDuck" };

            // Act
            List<String> output = superFizzBuzzAdvanced.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod4AndMod9_Return_FrogChicken()
        {
            // Arrange            
            long[] input = new long[] { 36,72 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "FrogChicken", "FrogChicken" };

            // Act
            List<String> output = superFizzBuzzAdvanced.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }
        [Test]
        public void SuperFizzBuzz_WhenMod4AndMod9AndMod13_Return_FrogDuckChicken()
        {
            // Arrange            
            long[] input = new long[] { 468,936 };
            // expected results as strings
            List<String> expectedOutput = new List<string> { "FrogDuckChicken", "FrogDuckChicken" };

            // Act
            List<String> output = superFizzBuzzAdvanced.GetOutput(input);

            // Assert
            Assert.That(expectedOutput, Is.EqualTo(output));
        }

        #endregion Advanced Tests - End
    }
}
