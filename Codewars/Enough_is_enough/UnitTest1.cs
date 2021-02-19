using NUnit.Framework;
using System.Linq;

namespace Enough_is_enough
{
    // Alice and Bob were on a holiday. Both of them took many pictures of the places they've been, 
    // and now they want to show Charlie their entire collection. However, Charlie doesn't like these 
    // sessions, since the motive usually repeats. He isn't fond of seeing the Eiffel tower 40 times. 
    // He tells them that he will only sit during the session if they show the same motive at most N times. 
    // Luckily, Alice and Bob are able to encode the motive as a number. Can you help them to remove
    // numbers such that their list contains each number only up to N times, without changing the order?

    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = arr.ToList();

            foreach (var item in arr)
            {
                int count = 0;

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == item)
                    {
                        count++;

                        if (count > x)
                            result.RemoveAt(i);
                    }
                }
            }
            return result.ToArray();
        }
    }

    [TestFixture]
    public class DeleteNthTests
    {
        [Test]
        public void TestSimple()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = Kata.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = Kata.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}