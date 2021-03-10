using NUnit.Framework;

namespace Take_a_Ten_Minute_Walk
{
    // You live in the city of Cartesia where all roads are laid out in a perfect grid. 
    // You arrived ten minutes too early to an appointment, so you decided to take the 
    // opportunity to go for a short walk. The city provides its citizens with a Walk 
    // Generating App on their phones -- everytime you press the button it sends you an 
    // array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']).
    // You always walk only a single block for each letter (direction) and you know it takes 
    // you one minute to traverse one city block, so create a function that will return true
    // if the walk the app gives you will take you exactly ten minutes (you don't want to be 
    // early or late!) and will, of course, return you to your starting point. Return false 
    // otherwise. 
    //
    //   "Note: you will always receive a valid array containing a random assortment of direction 
    // letters('n', 's', 'e', or 'w' only). It will never give you an empty array
    // (that's not a walk, that's standing still!)."

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