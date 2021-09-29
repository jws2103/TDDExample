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
        /// Deposit the money into my account
        /// </summary>
        /// <param name="amount">money to put</param>
        /// <returns>current balance</returns>
        double Deposit(double amount);

        /// <summary>
        /// Withdraw the money from my account
        /// </summary>
        /// <param name="amount">amount to withdraw</param>
        /// <returns>current balance</returns>
        double Withdraw(double amount);
    }
}
