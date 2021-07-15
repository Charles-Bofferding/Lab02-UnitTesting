using System;
using Xunit;
using UnitTesting;

namespace Test_Suite
{
    public class UnitTest1
    {

        

        //2 tests for each non-void method
        //ViewBalance, Withdraw, Deposit
        [Fact]
        public void InitialBalance()
        {
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(1000, Program.ViewBalance());
        }

        [Fact]
        public void FirstWithdrawal()
        {
            decimal value = 200;
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(800, Program.Withdraw(value));
        }

        [Fact]
        public void FirstDeposit()
        {
            decimal value = 100;
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(1100, Program.Deposit(value));
        }

        [Fact]
        public void SecondWithdrawal()
        {
            decimal value = 500;
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(500, Program.Withdraw(value));
        }

        //
        [Fact]
        public void SecondDeposit()
        {
            decimal value = 8001;
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(9001, Program.Deposit(value));
        }

        [Fact]
        public void EndBalance()
        {
            decimal current = Program.ViewBalance();
            Program.Withdraw(current);
            Program.Deposit(1000);
            Assert.Equal(1000, Program.ViewBalance());
        }

    }
}
