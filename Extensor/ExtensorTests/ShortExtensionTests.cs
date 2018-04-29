using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensor;
using System.Collections.Generic;

namespace ExtensorTests
{
    [TestClass]
    public class ShortExtensionTests
    {
        [TestMethod]
        public void TestIn()
        {
            short v = 2;
            v.In(2, 3);

            v = 6;
            IEnumerable<short> vs = new List<short>() { 4, 5, 6 };
            Assert.IsTrue(v.In(vs));
        }
    }
}
