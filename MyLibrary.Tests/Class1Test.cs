using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLibrary.Tests
{
    [TestClass]
    public class Class1Test
    {
        [TestMethod]
        public void GetFalseIsFalseTest()
        {
            Class1 class1 = new Class1();

            bool expected = class1.GetFalse();
            bool actual = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
