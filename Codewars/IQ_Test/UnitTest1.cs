using NUnit.Framework;
using System.Linq;

namespace IQ_Test
{
    // Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one
    // of the given numbers differs from the others. Bob observed that one number usually differs from
    // the others in evenness. Help Bob — to check his answers, he needs a program that among the given 
    // numbers finds one that is different in evenness, and return a position of this number.
    //  ! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the 
    //    elements start from 1 (not 0)

    public class IQ
    {
        public static int Test(string numbers)
        {
            int even = 0;
            int evenIndex = 0;
            int odd = 0;
            int oddIndex = 0;

            string[] numArray = numbers.Split(' ');

            for (int i = 0; i < numArray.Length; i++)
            {
                if (int.Parse(numArray[i]) % 2 == 0)
                {
                    even++;
                    evenIndex = i;
                }
                else
                {
                    odd++;
                    oddIndex = i;
                }
            }            
            if (even > 1)
                return oddIndex + 1;
            else
                return evenIndex + 1;
        }
    }

    [TestFixture]
    public class IQTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(1, IQ.Test("1 2 2"));
        }
    }
}