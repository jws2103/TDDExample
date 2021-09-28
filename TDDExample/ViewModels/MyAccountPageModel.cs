using System.Windows.Input;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace TDDExample
{
    [AddINotifyPropertyChangedInterface]
    public class MyAccountPageModel : FreshBasePageModel
    {
        private readonly IBankAccountService _bankAccountService;
        public MyAccountPageModel(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        public BankAccount MyAccount { get; set; }

        public double DepositAmount { get; set; }

        public double WithdrawAmount { get; set; }

        public ICommand DepositCommand => new Command(DoDeposit);

        public ICommand WithdrawCommand => new Command(DoWithDraw);

        private void CreateAccount()
        {
            /* Requirements
                1.  Create the account with your name and initial deposit when the page is initiated
                2.  Set MyAccount
                3.  Wrap with try & catch statement in case the exception is thrown
             */
            // TODO: Implements
        }

        private void DoDeposit()
        {
            /* Requirements
                1.  Call the Deposit method from IBankAccountService when DepositAmount is greater than 0
                2.  Update the Balance property of MyAccount
                3.  Wrap with try & catch statement in case the exception is thrown
             */
            // TODO: Implements
        }

        private void DoWithDraw()
        {
            /* Requirements
                1.  Call the Withdraw method from IBankAccountService when WithdrawAmount is greater than 0
                2.  Update the Balance property of MyAccount
                3.  Wrap with try & catch statement in case the exception is thrown
             */
            // TODO: Implements
        }
    }
}
