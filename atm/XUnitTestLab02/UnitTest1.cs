using atm;
using System;
using Xunit;
using static atm.Program;

namespace XUnitTestLab02
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 5001)]//passing valid input
        [InlineData(-5000, 1)]//passing invalid input, cannot add negative numbers
        public void CanDeposit(double value, double expectedResult)
        {
            Program.Balance = expectedResult;
            Assert.Equal(value + Balance, AddDeposit(value));            
        }

        [Theory]
        [InlineData(1, 4999)]//passing valid input
        [InlineData(1000000, 5000)]//passing invalid input, withdrawing a very large amount
        public void CanWithdraw(double value, double expectedResult)
        {
            Program.Balance = expectedResult;
            Assert.Equal(Balance - value, MinusWithdraw(value));
        }
    }
}
