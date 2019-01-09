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
            Assert.Equal(Convert.ToUInt32("5010"), Program.Deposit(5000, 10));
        }
        [Fact]
        public void AddThousandToZeroBalance()
        {
            Assert.Equal(Convert.ToUInt32("1000"), Program.Deposit(0, 1000));
        }
        [Fact]
        public void AddZeroToZeroBalance()
        {
            Assert.Equal(Convert.ToUInt32("0"), Program.Deposit(0, 0));
        }

        // Tests for Withdraw method
        [Fact]
        public void MinusFiveFromBalance()
        {
            Assert.Equal(Convert.ToUInt32("745"), Program.Withdraw(750, 5));
        }
        [Fact]
        public void MinusZeroFromBalance()
        {
            Assert.Equal(Convert.ToUInt32("1000"), Program.Withdraw(1000, 0));
        }
        [Fact]
        public void MinusZeroFromZero()
        {
            Assert.Equal(Convert.ToUInt32("0"), Program.Withdraw(0, 0));
        }
    }
}
