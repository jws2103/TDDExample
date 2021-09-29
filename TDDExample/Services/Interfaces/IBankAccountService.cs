namespace TDDExample
{
    public interface IBankAccountService
    {
        /// <summary>
        /// This will create your bank account
        /// </summary>
        /// <param name="accountHolder">holder name</param>
        /// <param name="depositAmount">initial deposit amount</param>
        /// <returns>account created</returns>
        BankAccount CreateAccount(string accountHolder, double initAmount);

        /// <summary>
        /// Get balance will return the current balance of my account
        /// </summary>
        /// <returns>current balance</returns>
        double GetBalance();

        /// <summary>
        /// Deposit the money into my account
        /// </summary>
        /// <param name="amount">money to put</param>
        /// <returns>success flag</returns>
        bool Deposit(double amount);

        /// <summary>
        /// Withdraw the money from my account
        /// </summary>
        /// <param name="amount">amount to withdraw</param>
        /// <returns>success flag</returns>
        bool Withdraw(double amount);
    }
}
