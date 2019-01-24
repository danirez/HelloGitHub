using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace TestHello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World", Program.CreateWord());
        }
    }
}
