using System;
using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class ObjectExtensionTests
    {
        [TestMethod]
        public void TestIsNull()
        {
            object o = "test";
            o = null;
            Assert.IsTrue(o.IsNull());
        }
    }
}
