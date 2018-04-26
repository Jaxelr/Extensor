using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class BoolExtensionTests
    {
        [TestMethod]
        public void TestToNumericValue()
        {
            string name = "batman";

            bool condition = name.Length == 6;

            Assert.IsTrue(condition.ToNumericValue() == 1);

            condition = "batman".Equals("robin");
            Assert.IsTrue(condition.ToNumericValue() == 0);
        }

        [TestMethod]
        public void TestToYesOrNo()
        {
            string name = "thebat";
            bool condition = name.Length == 6;

            Assert.IsTrue(condition.ToYesOrNo() == "YES");

            condition = "thehat".Equals("luffy");
            Assert.IsTrue(condition.ToYesOrNo() == "NO");
        }
    }
}
