using NUnit.Framework;
using System.Text.RegularExpressions;

namespace Disemvowel_Trolls
{
    // Trolls are attacking your comment section! A common way to deal with this situation
    // is to remove all of the vowels from the trolls' comments, neutralizing the threat.
    // Your task is to write a function that takes a string and return a new string with all
    // vowels removed. For example, the string "This website is for losers LOL!" would become
    // "Ths wbst s fr lsrs LL!".
    // Note: for this kata y isn't considered a vowel.

    public static class Kata
    {
        public static string Disemvowel(string str)
        {
            string vowelToEmpty = "";
            Regex regex = new Regex("[aeiou]", RegexOptions.IgnoreCase);
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