using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace Vowel_Count
{
    // Return the number (count) of vowels in the given string. We will consider a, e, i, o, u as vowels
    // for this Kata (but not y). The input string will only consist of lower case letters and/or spaces.

    public static class Kata
    {
        public static int GetVowelCount(string str)
        {
            //int vowelCount = 0;

            //foreach (char c in str)
            //{
            //    if (Regex.IsMatch(c.ToString(), "[aeiou]"))
            //        vowelCount++;
            //}
            //return vowelCount;

            return Regex.Matches(str, "[aeiou]").Count;
        }
    }

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}