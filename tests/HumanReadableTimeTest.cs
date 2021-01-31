using System;
using CodeWarsKatas.katas._5_kyu;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    public class HumanReadableTimeTest
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", HumanReadableTime.GetReadableTime(0));
            Assert.AreEqual("00:00:05", HumanReadableTime.GetReadableTime(5));
            Assert.AreEqual("00:01:00", HumanReadableTime.GetReadableTime(60));
            Assert.AreEqual("23:59:59", HumanReadableTime.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", HumanReadableTime.GetReadableTime(359999));
        }
    }
}