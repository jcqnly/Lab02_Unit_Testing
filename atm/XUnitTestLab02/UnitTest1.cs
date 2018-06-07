using atm;
using System;
using Xunit;

namespace XUnitTestLab02
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 5001)]//passing valid input
        [InlineData(-5000, 5001)]//passing invalid input, cannot add negative numbers
        public void CanDeposit(double value, double expectedResult)
        {
            Assert.Equal(expectedResult, Program.AddDeposit(value));            
        }

        [Theory]
        [InlineData(1, 5000)]//passing valid input
        [InlineData(1000000, 5000)]//passing invalid input, withdrawing a very large amount
        public void CanSubtract(double value, double expectedResult)
        {
            Assert.Equal(expectedResult, Program.MinusWithdraw(value));
        }
    }
}
