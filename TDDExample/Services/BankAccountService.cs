using System;
namespace TDDExample
{
    public class BankAccountService : IBankAccountService
    {
        private BankAccount _currentAccount;
        public BankAccount CreateAccount(string accountHolder, double initAmount)
        {
            /* Requirements
                1.1  Throw ArgumentInvalidException if account holder is null or empty string
                1.2. Throw ArgumentInvalidException if initAmount is less than 0
                2.  return BankAccount object with the fake account & bsb number
            */
            throw new NotImplementedException();
        }

        public double Deposit(double amount)
        {
            /* Requirements
                1.  Throw AccountNotFoundException if your current account doesn't exist
                2.  Add your balance by the amount passed over and return current balance
             */
            throw new NotImplementedException();
        }

        public double Withdraw(double amount)
        {
            /* Requirements
                1.  Throw AccountNotFoundException if your current account doesn't exist
                2.  Throw AmountExceedException if amount to withdraw is greater than the current balance
                3.  Subtract the amount from your current balance and return current balance
             */
            throw new NotImplementedException();
        }
    }
}
