using System;
using Extensor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensorTests
{
    [TestClass]
    public class DateTimeExtensionTests
    {
        [TestMethod]
        public void TestDaysTo()
        {
            DateTime now = DateTime.Now;
            DateTime twoDaysFromNow = now.Add(TimeSpan.FromDays(2));

            Assert.IsTrue(now.DaysTo(twoDaysFromNow) == 2);
        }

        [TestMethod]
        public void TestInTheFuture()
        {
            DateTime now = DateTime.Now.Add(TimeSpan.FromDays(99));
            Assert.IsTrue(now.InTheFuture());
        }

        [TestMethod]
        public void TestIsBetween()
        {
            DateTime now = DateTime.Now;
            DateTime twoDaysFromNow = now.Add(TimeSpan.FromDays(2));
            DateTime twoDaysBehindNow = now.Subtract(TimeSpan.FromDays(2));

            Assert.IsTrue(now.IsBetween(twoDaysBehindNow, twoDaysFromNow));
        }

        [TestMethod]
        public void TesIsNotBetween()
        {
            DateTime now = DateTime.Now;
            DateTime fourDaysFromNow = now.Add(TimeSpan.FromDays(4));
            DateTime twoDaysFromNow = now.Add(TimeSpan.FromDays(2));

            Assert.IsTrue(now.IsNotBetween(twoDaysFromNow, fourDaysFromNow));
        }

        [TestMethod]
        public void TestIsSunday()
        {
            DateTime now = DateTime.Parse("04/29/2018");
            Assert.IsTrue(now.IsSunday());
        }

        [TestMethod]
        public void TestIsMonday()
        {
            DateTime now = DateTime.Parse("4/30/2018");
            Assert.IsTrue(now.IsMonday());
        }

        [TestMethod]
        public void TestIsTuesday()
        {
            DateTime now = DateTime.Parse("5/01/2018");
            Assert.IsTrue(now.IsTuesday());
        }

        [TestMethod]
        public void TestIsWednesday()
        {
            DateTime now = DateTime.Parse("5/02/2018");
            Assert.IsTrue(now.IsWednesday());
        }

        [TestMethod]
        public void TestIsThursday()
        {
            DateTime now = DateTime.Parse("5/03/2018");
            Assert.IsTrue(now.IsThursday());
        }

        [TestMethod]
        public void TestIsFriday()
        {
            DateTime now = DateTime.Parse("5/04/2018");
            Assert.IsTrue(now.IsFriday());
        }

        [TestMethod]
        public void TestIsSaturday()
        {
            DateTime now = DateTime.Parse("5/05/2018");
            Assert.IsTrue(now.IsSaturday());
        }

    }
}
