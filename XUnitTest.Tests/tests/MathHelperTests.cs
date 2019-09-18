using Xunit;

namespace XUnitTest.Tests
{
    public class MathHelperTests
    {
        [Fact]
        public void WhenBothOperandsArePositive_ReturnsCorrectResult()
        {
            var sut = new MathHelper();

            var result = sut.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,3,5)]
        public void TestAddWithVariousInputs(int op1, int op2, int expectedResult)
        {
            var sut = new MathHelper();

            var result = sut.Add(op1, op2);

            Assert.Equal(expectedResult, result);
        }
    }

   
}
