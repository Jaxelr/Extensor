using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensor;
namespace ExtensorTests
{
    [TestClass]
    public class LongExtensionTests
    {
        [TestMethod]
        public void TestToFileSize()
        {
            long bytes = 10;
            long kilo = 1024;
            long meg = 2000000;
            long gig = 8888888888;
            long tera = 88888888888888;
            long peta = 88888888888888888;
            long exo = 1888888888888888888;

            Assert.IsTrue(bytes.ToFileSize().Contains("bytes"));
            Assert.IsTrue(kilo.ToFileSize().Contains("KB"));
            Assert.IsTrue(meg.ToFileSize().Contains("MB"));
            Assert.IsTrue(gig.ToFileSize().Contains("GB"));
            Assert.IsTrue(tera.ToFileSize().Contains("TB"));
            Assert.IsTrue(peta.ToFileSize().Contains("PB"));
            Assert.IsTrue(exo.ToFileSize().Contains("EB"));
        }
    }
}
