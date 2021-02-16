using System;
using NUnit.Framework;

namespace Counting_Duplicates
{
    //   Count the number of Duplicates
    //  Write a function that will return the count of distinct case-insensitive 
    // alphabetic characters and numeric digits that occur more than once in the 
    // input string. The input string can be assumed to contain only alphabets(both 
    // uppercase and lowercase) and numeric digits.

    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            string lowStr = str.ToLower();
            char[] ch = lowStr.ToCharArray();
            char[] resultCh = new char[ch.Length];
            int count = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                if (Array.IndexOf(ch, ch[i], i + 1) > 0)
                {
                    if (Array.IndexOf(resultCh, ch[i], 0) < 0)
                    {
                        resultCh[count] = ch[i];
                        count++;
                    }
                }
            }
            return count;
        }
    }

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual(0, Kata.DuplicateCount(""));
            Assert.AreEqual(0, Kata.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}