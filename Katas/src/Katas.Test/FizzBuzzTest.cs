using Xunit;
using Katas.FizzBuzz;

namespace Katas.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void CanReturnFizz()
        {
            //arrange
            var fizzBuzz = new Printer();

            //act
            var actualResult = fizzBuzz.PrintNumbersFromOneToHundred();

            //assert
            Assert.True(actualResult.Contains("Fizz"));
            Assert.True(actualResult.Contains("Buzz"));
        }

        [Fact]
        public void CanReturnBuzz()
        {
            //arrange
            var fizzBuzz = new Printer();

            //act
            var actualResult = fizzBuzz.PrintNumbersFromOneToHundred();

            //assert
            Assert.True(actualResult.Contains("Buzz"));
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(3, true)]
        public void IsInputFizzAsExpected(int inputNumber, bool expectedResult)
        {
            var actualResult = inputNumber.IsFizz();

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, false)]
        [InlineData(5, true)]
        public void IsInputBuzzAsExpected(int inputNumber, bool expectedResult)
        {
            var actualResult = inputNumber.IsBuzz();

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
