using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extensor;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExtensorTests
{
    [TestClass]
    public class StringExtensionTests
    {
        string v;
        string date;
        string[] values;
        IEnumerable<string> enumerables;


        [TestInitialize]
        public void TestInit()
        {
            v = null;
            date = "1/1/2018";
            values = new string[] { "extensor", "jrsosadev", "puertorico", "android" };
            enumerables = values.AsEnumerable();
        }

        [TestMethod]
        public void TestHasText()
        {
            v = "Extensor is awesome!";
            Assert.IsTrue(v.HasText());
        }

        [TestMethod]
        public void TestIn()
        {
            Assert.IsFalse(v.In(values));
            Assert.IsTrue("extensor".In(values));
            Assert.IsTrue("android".In(enumerables));
        }

        [TestMethod]
        public void TestInIgnoringCasing()
        {
            Assert.IsTrue("Extensor".InIgnoringCasing(values));
            Assert.IsTrue("Android".InIgnoringCasing(enumerables));
        }


        [TestMethod]
        public void TestIsADate()
        {
            Assert.IsTrue(date.IsADate());

            date = "2018/1/1";
            Assert.IsTrue(date.IsADate());

            date = "2018/99/99";
            Assert.IsFalse(date.IsADate());
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(v.IsEmpty());
            v = "   ";
            Assert.IsTrue(v.IsEmpty());
            v = "";
            Assert.IsTrue(v.IsEmpty());
        }

        [TestMethod]
        public void TestNotIn()
        {
            Assert.IsTrue(v.NotIn(values));
            Assert.IsTrue("Android".NotIn(values));
            Assert.IsTrue("Extensor".NotIn(enumerables));
        }

        [TestMethod]
        public void TestNotIgnoringCasing()
        {
            Assert.IsTrue(v.NotIn(values));
            Assert.IsTrue("Tensor".NotIn(values));
            Assert.IsTrue("iphone".NotIn(enumerables));
        }

        [TestMethod]
        public void TestRemoveEverythingBefore()
        {
            string expected = "Extensor Portable Class library is awesome!";
            v = "The Extensor Portable Class library is awesome!";

            Assert.AreEqual(v.RemoveEverythingBefore('E'), expected);
        }

        [TestMethod]
        public void TestSplitByEnviromentNewLine()
        {
            int amount = 3;
            var names = $"Skeletor,{Environment.NewLine}IronMan,{Environment.NewLine}Sasuke";

            Assert.IsTrue(names.SplitByEnvironmentNewLine().Count() == amount);

            amount = 2;
            names = @"Batman
                      Robin";

            Assert.IsTrue(names.SplitByEnvironmentNewLine().Count() == amount);
        }


        [TestMethod]
        public void TestToByteArray()
        {
            v = "abc";
            var vByteArray = v.ToByteArray(encoding: Encoding.ASCII);
            Assert.IsTrue(vByteArray.Length == 3);
            Assert.IsTrue(vByteArray[0] == 97);
            Assert.IsTrue(vByteArray[1] == 98);
            Assert.IsTrue(vByteArray[2] == 99);
        }

        [TestMethod]
        public void TestValueBetween()
        {
            v = "The portable library extensor, made with love in Puerto Rico";
            Assert.IsTrue(v.ValueBetween("portable", "extensor").Equals("library"));
        }
    }
}
