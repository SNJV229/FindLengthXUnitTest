using System;
using Xunit;
using FindLenghth;

namespace FindLengthTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("123456789010")]
        //[Fact]
        public void findLengthForNotNullTest(string str)
        {
            //Arrange
            //string str = "";

            //Act
            int len = 0;
            foreach (char ch in str)
            {
                len += 1;
            }

            //Assert
            Assert.Equal(len, LengthHelper.findLength(str));
           
        }
        [Fact]
        public void ThrowForNullException()
        {
            string str = null;
            var exception = Assert.Throws<NullReferenceException>(() => LengthHelper.findLength(str));
            Assert.Equal("Null value is invalid.", exception.Message);
        }
    }
}
