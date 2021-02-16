using System;
using NUnit.Framework;

namespace Convert_boolean_values_to_strings
{
    // Complete the method that takes a boolean value and return a "Yes" string for true,
    // or a "No" string for false.

    public static class Kata
    {
        public static string boolToWord(bool word)
        {
            if (word == true)
                return "Yes";
            else
                return "No";

            // return word ? "Yes" : "No";    
        }
    }

    [TestFixture]
    public class boolToWordTest
    {
        [Test]
        public void boolToWordReturned1()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }

        [Test]
        public void boolToWordReturned2()
        {
            Assert.AreEqual("No", Kata.boolToWord(false));
            Console.WriteLine("Expected No");
        }

        [Test]
        public void boolToWordReturned3()
        {
            Assert.AreEqual("Yes", Kata.boolToWord(true));
            Console.WriteLine("Expected Yes");
        }
    }
}