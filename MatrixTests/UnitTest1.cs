using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EkzamMatrix;

namespace MatrixTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            int expected = 6;

            Output result = new Output();
            int actual = result.ResultTest(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
