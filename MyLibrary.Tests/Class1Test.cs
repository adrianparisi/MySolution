using Xunit;

namespace MyLibrary.Tests
{
    public class Class1Test
    {
        [Fact]
        public void GetFalseIsFalseTest()
        {
            Class1 class1 = new Class1();

            bool expected = false;
            bool actual = class1.GetFalse(); ;

            Assert.Equal(expected, actual);
        }
    }
}
