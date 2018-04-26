using System.Collections.Generic;
using System.Linq;
using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class IEnumerableExtensionTests
    {
        [TestMethod]
        public void TestForEach()
        {
            var names = new string[] { "batman", "ironman", "catwoman" };
            var expected = new string[] { "batman", "ironman", "catwoman" };

            names.ForEach((index, hero) =>
            {
                Assert.IsTrue(hero == expected[index]);
                Assert.IsTrue(names[index] == expected[index]);

            });
        }

        [TestMethod]
        public void TestHasRecords()
        {
            var names = new string[] { "batman", "ironman", "catwoman" };
            Assert.IsTrue(names.HasRecords());
        }


        [TestMethod]
        public void TestMissingIn()
        {
            var names = new string[] { "batman", "ironman", "catwoman" };
            var animes = new string[] { "OnePiece", "BlackClover", "DragonBallSuper" };
            Assert.IsTrue(names.MissingIn(animes).Count() > 0);

            var ages = new int[] { 18, 21, 120 };
            var minors = new int[] { 15, 16, 17 };
            Assert.IsTrue(ages.MissingIn(minors).Count() > 0);
        }


        [TestMethod]
        public void TestToCommaSeparatedValues()
        {
            var names = new string[] { "batman", "ironman", "catwoman" };
            var expected = "batman,ironman,catwoman";
            Assert.AreEqual(expected, names.ToCommaSeparatedValues());
        }

        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        [TestMethod]
        public void TestToCommaSeparatedValues_ThrowEx()
        {
            var s = new List<string>();
            s.ToCommaSeparatedValues();
        }
    }
}
