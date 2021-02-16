using System;
using NUnit.Framework;

namespace Persistent_Bugger
{
    // Write a function, persistence, that takes in a positive parameter num and returns
    // its multiplicative persistence, which is the number of times you must multiply the 
    // digits in num until you reach a single digit.

    public class Persist
    {
        public static int Persistence(long n)
        {
            int count = 0;

            while (n.ToString().Length > 1)
            {
                long result = 1;

                foreach (var item in n.ToString())
                {
                    int multiplier = int.Parse(item.ToString());
                    result *= multiplier;
                }
                n = result;
                count++;
            }
            return count;
        }
    }

    [TestFixture]
    public class PersistTests
    {
        [Test]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }
    }
}