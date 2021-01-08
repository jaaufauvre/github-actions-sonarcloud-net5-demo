using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassLibrary.Tests
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello", Class1.Hello());
        }
    }
}
