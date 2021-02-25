using NUnit.Framework;
using System.Collections.Generic;

namespace Replace_With_Alphabet_Position
{
    // In this kata you are required to, given a string, replace every letter with its
    // position in the alphabet. If anything in the text isn't a letter, ignore it and
    // don't return it. 
    // "a" = 1, "b" = 2, etc.

    public static class Kata
    {
        public static string AlphabetPosition(string text)
        {
            string result = "";
            var replaceChar = new Dictionary<char, int>();

            for (int i = 0; i < 26; i++)
            {
                //replaceChar.Add((char)('a' + i), i + 1);
                replaceChar.Add((char)('A' + i), i + 1);
            }
            foreach (char ch in text)
            {
                if (replaceChar.ContainsKey(char.ToUpper(ch)))
                    result += replaceChar[char.ToUpper(ch)] + " ";
            }
            return result.Trim();
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", Kata.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", Kata.AlphabetPosition("The narwhal bacons at midnight."));
        }
    }
}