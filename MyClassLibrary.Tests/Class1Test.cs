using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyClassLibrary.Tests
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.IsTrue(Class1.Hello().Contains("Hello"));
        }
    }
}
