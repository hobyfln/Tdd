using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TddTests
{
    [TestClass]
    public class YipYopTests
    {
        YipYop yipyop = new YipYop();

        [TestMethod]
        public void ConfirmGenerateReturn1()
        {
            Assert.AreEqual("1", yipyop.generate(1, 1), "Ko pour 1");
        }
        [TestMethod]
        public void ConfirmGenerateReturn2()
        {
            Assert.AreEqual("2", yipyop.generate(2, 2), "Ko pour 2");
        }
        [TestMethod]
        public void ConfirmGenerateReturn3()
        {
            Assert.AreEqual("yop", yipyop.generate(3, 3), "Ko pour 3");
        }
        [TestMethod]
        public void ConfirmGenerateReturn5()
        {
            Assert.AreEqual("yip", yipyop.generate(5, 5), "Ko pour 5");
        }
        [TestMethod]
        public void ConfirmGenerateReturn6()
        {
            Assert.AreEqual("yop", yipyop.generate(6, 6), "Ko pour 6");
        }
        [TestMethod]
        public void ConfirmGenerateReturn10()
        {
            Assert.AreEqual("yip", yipyop.generate(10, 10), "Ko pour 10");
        }
        [TestMethod]
        public void ConfirmGenerateReturn15()
        {
            Assert.AreEqual("yipyop", yipyop.generate(15, 15), "Ko pour 15");
        }
        [TestMethod]
        public void ConfirmGenerateReturn12()
        {
            Assert.AreEqual("12", yipyop.generate(1, 2), "Ko pour 1-2");
        }
        [TestMethod]
        public void ConfirmGenerateReturn12yop()
        {
            Assert.AreEqual("12yop", yipyop.generate(1 ,3), "Ko pour 1-2-yop");//yop == 3
        }
    }

}

