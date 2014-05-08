using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorv1;



namespace tesPro
{
    [TestClass]
    public class UnitTest1
    {
        private MainWindow mw;
        [TestMethod]
        public void TestMethod1()
        {
            
            double a = 2;
            double c = mw.tmbh(1, 1);
            Assert.AreEqual(a, c, "a");
        }

    }
}
