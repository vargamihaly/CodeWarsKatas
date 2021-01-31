using System.Collections.Generic;
using CodeWarsKatas.katas._6_kyu;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    public class CountCharactersInYourStringTest
    {
        [Test]
        public static void FixedTest_aaaa()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 4);
            Assert.AreEqual(d, CountCharactersInYourString.Count("aaaa"));
        }
  
        [Test]
        public static void FixedTest_aabb()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('a', 2);
            d.Add('b', 2);
            Assert.AreEqual(d, CountCharactersInYourString.Count("aabb"));
        }
    }
}