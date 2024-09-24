using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = true;
            bool actualResutl = o.IsLeapYear(2000);
            Assert.AreEqual(expectedResutl, actualResutl);
        }


        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = true;
            bool actualResutl = o.IsLeapYear(2024);
            Assert.AreEqual(expectedResutl, actualResutl);
        }


        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.IsLeapYear(2005);
            Assert.AreEqual(expectedResutl, actualResutl);
        }


        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Exception expectedException = null;
            try
            {
                bool acturalResult = methodLibrary.IsLeapYear(1580);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            bool expectedResutl = false;
            bool actualResutl = o.IsLeapYear(1582);
            Assert.AreEqual(expectedResutl, actualResutl);
        }

        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            Exception expectedException = null;
            try
            {
                bool acturalResult = methodLibrary.IsLeapYear(1581);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }



    }
}
