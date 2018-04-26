using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class DoubleExtensionTests
    {
        double v;
        double[] values;

        [TestInitialize]
        public void TestInit()
        {
            v = 2.14;
            values = new double[] { 2.14, 3.00, 1.2, 5 };
        }

        [TestMethod]
        public void TestIsBetween()
        {
            Assert.IsTrue(v.IsBetween(2.14, 5.55));
        }

        [TestMethod]
        public void TestIsNotBetween()
        {
            Assert.IsTrue(v.IsNotBetween(2.15, 2.18));
        }

        [TestMethod]
        public void TestIn()
        {
            Assert.IsTrue(v.In(values));
        }

        [TestMethod]
        public void TestNotIn()
        {
            v = 99.99;
            Assert.IsTrue(v.NotIn(values));
        }
    }
}
