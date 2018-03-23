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
            var siblingNumber = new SiblingNumber();
            var result = siblingNumber.Largest(355);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart2()
        {
            var siblingNumber = new SiblingNumber();
            var result = siblingNumber.Largest(535);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart3()
        {
            var siblingNumber = new SiblingNumber();
            var result = siblingNumber.Largest(553);

            Assert.AreEqual(553, result);
        }

        [TestMethod]
        public void LargestSiblingNumberCanSatisfyBasicTestPart4()
        {
            var siblingNumber = new SiblingNumber();
            var result = siblingNumber.Largest(123);

            Assert.AreEqual(321, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CanISendNegativeNumber()
        {
            var siblingNumber = new SiblingNumber();
            var result = siblingNumber.Largest(-1);
        }
    }
}
