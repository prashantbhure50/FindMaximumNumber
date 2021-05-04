using FindMaximumNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestMaximumNumber
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void GivenMaxIntegerAtFirstPosition_WhenCheck_ShouldReurnMaximumInteger()
        {
            int result=MaximumNumber.Maximum(3,2,1);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void GivenMaxIntegerAtSecondPosition_WhenCheck_ShouldReurnMaximumInteger()
        {
            int result = MaximumNumber.Maximum(1,3,2);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void GivenMaxIntegerAtThirdPosition_WhenCheck_ShouldReurnMaximumInteger()
        {
            int result = MaximumNumber.Maximum(1,2,3);
            Assert.AreEqual(result, 3);
        }
        [TestMethod]
        public void GivenMaxFloat_WhenCheck_ShouldReurnMaximumFloatValue()
        {
            float result = MaximumNumber.Maximum(1.1f, 2.4f, 3.4f);
            Assert.AreEqual(result, 3.4f);
        }
        [TestMethod]
        public void GivenMaxString_WhenCheck_ShouldReurnMaximumStringValue()
        {
            string result = MaximumNumber.Maximum("Apple","Peach","banana");
            Assert.AreEqual(result, "Peach");
        }
    }
}
