using CodeWarsKatas.katas._6_kyu;
using NUnit.Framework;

namespace CodeWarsKatas.tests
{
    public class DataReverseTest
    {
        [Test]
        public static void test1() {
            int[] data1= new int [32] {1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0};
            int[] data2= new int [32] {1,0,1,0,1,0,1,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1};
            Assert.AreEqual(data2,DataReverse.DataReverser(data1));
        }

        [Test]
        public static void test2() {
            int[] data1= new int [16] {0,0,1,1,0,1,1,0,0,0,1,0,1,0,0,1};
            int[] data2= new int [16] {0,0,1,0,1,0,0,1,0,0,1,1,0,1,1,0};
            Assert.AreEqual(data2,DataReverse.DataReverser(data1));
        }
    }
}