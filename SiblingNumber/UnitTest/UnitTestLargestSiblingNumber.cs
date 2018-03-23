using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathCode;

namespace UnitTest
{
    [TestClass]
    public class UnitTestLargestSiblingNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new SiblingNumber();
            var result = service.Largest(213);
        }
    }
}
