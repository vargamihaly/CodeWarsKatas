using System.Collections.Generic;
using CodeWarsKatas.katas._6_kyu;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    public class BreakCamelCaseTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }
  
        [Test, TestCaseSource("testCases")]
        public string Test(string str) => BreakCamelCase.BreakCamelCasE(str);
    }
}