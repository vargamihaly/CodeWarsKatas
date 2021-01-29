using System;
using System.Collections.Generic;
using System.Text;
using CodeWarsKatas.katas;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    [TestFixture]
    class NumberOfPeopleInTheBusTest
    {
        [Test]
        public void FirstTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, NumberOfPeopleInTheBus.Number(peopleList));
        }
        [Test]
        public void SecondTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, NumberOfPeopleInTheBus.Number(peopleList));
        }
        [Test]
        public void ThirdTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, NumberOfPeopleInTheBus.Number(peopleList));
        }
    }
}
