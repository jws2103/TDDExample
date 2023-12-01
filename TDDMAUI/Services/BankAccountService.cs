using TDDMAUI.Models;
using TDDMAUI.Services.Interfaces;

namespace TDDMAUI.Services;

public class BankAccountService : IBankAccountService
{
    public BankAccount CreateAccount(string accountHolder, double initAmount)
    {
        return null;
    }

    public double Deposit(double amount)
    {
        /* Requirements
            1.  Throw AccountNotFoundException if your current account doesn't exist
            2.  Add your balance by the amount passed over
         */
        return 0;
    }

    public double Withdraw(double amount)
    {
        /* Requirements
            1.  Throw AccountNotFoundException if your current account doesn't exist
            2.  Throw AmountExceedException if amount to withdraw is greater than the current balance
            3.  Subtract the amount from your current balance
         */
        return 0;
    }
}