using System;
namespace TDDExample
{
    public class BankAccountService : IBankAccountService
    {
        private BankAccount _currentAccount;
        public BankAccount CreateAccount(string accountHolder, double initAmount)
        {
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            throw new NotImplementedException();
        }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
