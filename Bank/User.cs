using System;
namespace BankSystem
{
    class User
    {
        public string Name = "";
        public string UserAccountNumber = "";
        public string ID = "";
        Wallet? UserWallet;


        public void Register(Wallet InputWallet)
        {
            UserWallet.balance = InputWallet.balance;
            UserWallet.Name = InputWallet.Name;
            UserWallet.AccountNum = InputWallet.AccountNum;
        }




    }
}