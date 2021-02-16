using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Isograms
{
    public class Kata
    {
        public static bool IsIsogram(string str)
        {
            string lowStr = str.ToLower();
            char[] ch = lowStr.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (Array.IndexOf(ch, ch[i], i + 1) > 0)
                    return false;
            }
            return true;
        }
    }

    [TestFixture]
    public class BasicTests
    {

        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str) => Kata.IsIsogram(str);
    }
}