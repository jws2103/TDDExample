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

        public ICommand DepositCommand => new Command(DoDeposit);

        public ICommand WithdrawCommand => new Command(DoWithDraw);

        private void CreateAccount()
        {
            // TODO: Implements
        }

        private void DoDeposit()
        {
            // TODO: Implements
        }

        private void DoWithDraw()
        {
            // TODO: Implements
        }
    }
}
