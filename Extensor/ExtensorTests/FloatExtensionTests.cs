using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class FloatExtensionTests
    {
        float v;
        float[] values;

        [TestInitialize]
        public void TestInit()
        {
            v = 35f;
            values = new float[] { 0.25f, 1f, 35f };
        }

        [TestMethod]
        public void TestIsBetween()
        {
            Assert.IsTrue(v.IsBetween(34f, 36f));
        }

        [TestMethod]
        public void TestIsNotBetween()
        {
            Assert.IsTrue(v.IsNotBetween(1f, 34f));
        }

        [TestMethod]
        public void TestIn()
        {
            Assert.IsTrue(v.In(values));
        }

        [TestMethod]
        public void TestNotIn()
        {
            v = -1f;
            Assert.IsTrue(v.NotIn(values));
        }
    }
}

