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
            MaximumNumber<int> maxInteger = new MaximumNumber<int>(4, 2, 3);
            Assert.AreEqual(maxInteger.maxMethod(),4);
        }
        [TestMethod]
        public void GivenMaxIntegerAtSecondPosition_WhenCheck_ShouldReurnMaximumInteger()
        {
            MaximumNumber<int> maxInteger = new MaximumNumber<int>(4, 6, 3);
            Assert.AreEqual(maxInteger.maxMethod(), 6);
        }
        [TestMethod]
        public void GivenMaxIntegerAtThirdPosition_WhenCheck_ShouldReurnMaximumInteger()
        {
            MaximumNumber<int> maxInteger = new MaximumNumber<int>(3, 2, 4);
            Assert.AreEqual(maxInteger.maxMethod(), 4);
        }
        [TestMethod]
        public void GivenMaxFloat_WhenCheck_ShouldReurnMaximumFloatValue()
        {
            MaximumNumber<float> maxInteger = new MaximumNumber<float>(4.4f, 2.4f, 3.6f);
            Assert.AreEqual(maxInteger.maxMethod(), 4.4f);
        }
        [TestMethod]
        public void GivenMaxString_WhenCheck_ShouldReurnMaximumStringValue()
        {
            MaximumNumber<string> maxInteger = new MaximumNumber<string>("Apple","Peach","Banana");
            Assert.AreEqual(maxInteger.maxMethod(), "Peach");
        }
    }
}
