using System;
using System.Collections.Generic;
using System.Text;
using CodeWarsKatas.katas;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    class SumOfASequenceTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(12, SumOfASequence.SequenceSum(2, 6, 2));
            Assert.AreEqual(15, SumOfASequence.SequenceSum(1, 5, 1));
            Assert.AreEqual(5, SumOfASequence.SequenceSum(1, 5, 3));
            Assert.AreEqual(45, SumOfASequence.SequenceSum(0, 15, 3));
            Assert.AreEqual(0, SumOfASequence.SequenceSum(16, 15, 3));
            Assert.AreEqual(26, SumOfASequence.SequenceSum(2, 24, 22));
            Assert.AreEqual(2, SumOfASequence.SequenceSum(2, 2, 2));
            Assert.AreEqual(2, SumOfASequence.SequenceSum(2, 2, 1));
            Assert.AreEqual(35, SumOfASequence.SequenceSum(1, 15, 3));
            Assert.AreEqual(0, SumOfASequence.SequenceSum(15, 1, 3));
        }
    }
}
