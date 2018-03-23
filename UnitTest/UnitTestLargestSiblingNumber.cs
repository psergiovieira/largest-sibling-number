using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathCode;

namespace UnitTest
{
    [TestClass]
    public class UnitTestLargestSiblingNumber
    {
        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart1()
        {
            var service = new SiblingNumber();
            var result = service.Largest(355);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart2()
        {
            var service = new SiblingNumber();
            var result = service.Largest(535);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart3()
        {
            var service = new SiblingNumber();
            var result = service.Largest(553);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart4()
        {
            var service = new SiblingNumber();
            var result = service.Largest(123);

            Assert.AreEqual(321, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanISendNegativeNumber()
        {
            var service = new SiblingNumber();
            var result = service.Largest(-1);
        }
    }
}
