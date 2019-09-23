using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd;

namespace TddTests
{
    [TestClass()]
    public class YipYopTests
    {

            YipYop yipyop= new YipYop();

        [TestMethod()]
        public void ConfirmGenerateReturn1()
        {
            Assert.AreEqual("1", yipyop.generate(1), "ko pour 1");
        }

        [TestMethod()]
        public void ConfirmGenerateReturn2()
        {
            Assert.AreEqual("2", yipyop.generate(2), "ko pour 2");
        }

        [TestMethod()]
        public void ConfirmGenerateReturn3()
        {
            Assert.AreEqual("3", yipyop.generate(3), "ko pour 3");
        }

        [TestMethod()]
        public void ConfirmGenerateReturn5()
        {
            Assert.AreEqual("5", yipyop.generate(5), "ko pour 5");
        }

        [TestMethod()]
        public void ConfirmGenerateReturn10()
        {
            Assert.AreEqual("10", yipyop.generate(10), "ko pour 10");
        }
    }
}
