using System;
using Xunit;
using ATM;

namespace XUnitTestATM
{
    public class UnitTest1
    {
        // Tests for Deposit method
        [Fact]
        public void AddTenToBalance()
        {
            Assert.Equal(5010, (int)Program.Deposit(5000, 10));
        }
        [Fact]
        public void AddThousandToZeroBalance()
        {
            Assert.Equal(1000, (int)Program.Deposit(0, 1000));
        }
        [Fact]
        public void AddZeroToZeroBalance()
        {
            Assert.Equal(0, (int)Program.Deposit(0, 0));
        }

        // Tests for Withdraw method
        [Fact]
        public void MinusFiveFromBalance()
        {
            Assert.Equal(745, (int)Program.Withdraw(750, 5));
        }
        [Fact]
        public void MinusZeroFromBalance()
        {
            Assert.Equal(1000, (int)Program.Withdraw(1000, 0));
        }
        [Fact]
        public void MinusTenFromZeroBalance()
        {
            Assert.Equal(-10, (int)Program.Withdraw(0, 10));
        }
    }
}
