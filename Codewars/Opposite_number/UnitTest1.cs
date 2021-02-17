using NUnit.Framework;

namespace Opposite_number
{
    // Very simple, given a number, find its opposite.

    public class Kata
    {
        public static int Opposite(int number)
        {
            return -number;
        }
    }

    [TestFixture]
    public class MyTest
    {
        [Test]
        public void Test_1()
        {
            Assert.AreEqual(-1, Kata.Opposite(1));
        }
    }
}