using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Rot13
{
    // ROT13 is a simple letter substitution cipher that replaces a letter with the letter
    // 13 letters after it in the alphabet.ROT13 is an example of the Caesar cipher.
    // Create a function that takes a string and returns the string ciphered with Rot13. 
    // If there are numbers or special characters included in the string, they should be 
    // returned as they are. Only letters from the latin/english alphabet should be shifted,
    // like in the original Rot13 "implementation".

    public class Kata
    {
        public static string Rot13(string message)
        {
            string result = "";
            var replaceChar = new Dictionary<char, char>();

            for (int i = 0; i < 26; i++)
            {
                replaceChar.Add((char)('a' + i), (char)('a' + (i + 13) % 26));
                replaceChar.Add((char)('A' + i), (char)('A' + (i + 13) % 26));
            }

            foreach (char ch in message)
            {
                if (replaceChar.ContainsKey(ch))
                    result += replaceChar[ch];
                else result += ch;
            }
            return result;
        }           
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("test")]
        public void testTest()
        {
            Assert.AreEqual("grfg", Kata.Rot13("test"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Kata.Rot13("test")));
        }

        [Test, Description("Test")]
        public void TestTest()
        {
            Assert.AreEqual("Grfg", Kata.Rot13("Test"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Kata.Rot13("Test")));
        }
    }
}