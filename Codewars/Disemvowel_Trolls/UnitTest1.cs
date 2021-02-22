using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Disemvowel_Trolls
{
    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string vowelToEmpty = "";
            Regex regex = new Regex(@"[aeiouy]", RegexOptions.IgnoreCase);
            return regex.Replace(str, vowelToEmpty);            
        }
    }

    [TestFixture]
    public class DisemvowelTest
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
        }
    }
}