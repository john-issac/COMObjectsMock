using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMObjectsMock;

namespace COMMockTests
{
    [TestClass]
    public class TestMain
    {
        [TestMethod]
        public void TestDoSomething()
        {
            DummyCOMObject dummy = new DummyCOMObject();
            Main target = new Main(dummy);
            short expected = 30;
            short result = target.DoSomething();
            Assert.AreEqual(expected, result);
        }
    }
}
