using System;
using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class IntExtensionTests
    {
        int v;
        int[] values;

        [TestInitialize]
        public void TestInit()
        {
            v = 787;
            values = new int[] { 1, 2, 3, 4, 5, 6, 787 };
        }

        [TestMethod]
        public void TestIsBetween()
        {
            Assert.IsTrue(v.IsBetween(700, 800));
        }

        [TestMethod]
        public void TestIsNotBetween()
        {
            Assert.IsTrue(v.IsNotBetween(400, 500));
        }

        [TestMethod]
        public void TestIn()
        {
            Assert.IsTrue(v.In(values));
        }

        [TestMethod]
        public void TestNotIn()
        {
            v = -1;
            Assert.IsTrue(v.NotIn(values));
        }
    }
}
