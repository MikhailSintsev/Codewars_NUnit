using NUnit.Framework;

namespace Take_a_Ten_Minute_Walk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            int horizontal = 0;
            int vertical = 0;

            foreach (var direction in walk)
            {
                if (direction == "n")
                    vertical += 1;
                if (direction == "s")
                    vertical -= 1;
                if (direction == "w")
                    horizontal -= 1;
                if (direction == "e")
                    horizontal += 1;
            }

            if (vertical == 0 && horizontal == 0)
                return true;

            return false;
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
    }
}