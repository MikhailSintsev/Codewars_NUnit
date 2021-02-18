using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace Unique_In_Order
{
    // Implement the function unique_in_order which takes as argument a sequence and returns
    // a list of items without any elements with the same value next to each other and preserving 
    // the original order of elements.

    public static class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var list = new List<T>();

            foreach (var item in iterable)
                list.Add(item);

            for (int i = 0; i < list.Count; i++)
            {
                while ((i + 1) < list.Count && list[i].Equals(list[i + 1]))
                    list.RemoveAt(i + 1);
            }
            return list;
        }
    }

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}