using System;
using NUnit.Framework;

namespace Square_Every_Digit
{
    // Welcome. In this kata, you are asked to square every digit of a number and concatenate them.
    // For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
    // Note: The function accepts an integer and returns an integer

    public class Kata
    {
        public static int SquareDigits(int n)
        {
            string result = "";

            foreach (char item in n.ToString())
            {
                int multiplier = int.Parse(item.ToString());
                result += (multiplier * multiplier);
            }
            return int.Parse(result);
        }
    }

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void SquareDigitsTest()
        {
            Assert.AreEqual(811181, Kata.SquareDigits(9119));
        }
    }
}