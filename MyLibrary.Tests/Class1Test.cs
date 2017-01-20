using Xunit;

namespace MyLibrary.Tests
{
    public class Class1Test
    {
        [Fact]
        public void GetFalseIsFalseTest()
        {
            Class1 class1 = new Class1();

            bool expected = class1.GetFalse();
            bool actual = false;

            Assert.Equal(expected, actual);
        }
    }
}
