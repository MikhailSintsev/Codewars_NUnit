using System;
using NUnit.Framework;

namespace Square_Every_Digit
{
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