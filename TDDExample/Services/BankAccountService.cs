using System;
namespace TDDExample
{
    public class BankAccountService : IBankAccountService
    {
        private BankAccount _currentAccount;
        public BankAccount CreateAccount(string accountHolder, double initAmount)
        {
            /* Requirements
                1.1  Throw the exception if account holder is null or empty string
                1.2. Throw the exception if initAmount is less than 0
                2.  return BankAccount object with the fake account & bsb number
            */
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            /* Requirements
                1.  Throw the exception if your current account doesn't exist
                2.  Return the balance of your current account
             */
            throw new NotImplementedException();
        }

        public void Deposit(double amount)
        {
            /* Requirements
                1.  Throw the exception if your current account doesn't exist
                2.  Add your balance by the amount passed over
             */
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            /* Requirements
                1.  Throw the exception if your current account doesn't exist
                2.  Subtract the amount from your current balance
             */
            throw new NotImplementedException();
        }
    }
}
