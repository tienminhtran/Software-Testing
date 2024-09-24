using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = true;
            bool actualResutl = o.primeCheck(37);
            Assert.AreEqual(expectedResutl, actualResutl);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.primeCheck(25);
            Assert.AreEqual(expectedResutl, actualResutl);
        }


        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.primeCheck(1);
            Assert.AreEqual(expectedResutl, actualResutl);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = true;
            bool actualResutl = o.primeCheck(2);
            Assert.AreEqual(expectedResutl, actualResutl);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.primeCheck(0);
            Assert.AreEqual(expectedResutl, actualResutl);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.primeCheck(1000);
            Assert.AreEqual(expectedResutl, actualResutl);
        }
    }
}
