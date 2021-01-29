using System;
using System.Collections.Generic;
using System.Text;
using CodeWarsKatas.katas;

namespace CodeWarsKatas.tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        public Tests()
        {
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public string FixedTest(int[] numbers)
        {
            return CreatePhoneNumber.CreatePhoneNumberSolution(numbers);
        }
    }
}
