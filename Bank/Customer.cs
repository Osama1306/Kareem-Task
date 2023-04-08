using System;
namespace BankSystem
{
    class Customer : User
    {
        public string CustomerName;
        public string CustomerAccountNumber;
        public float CustomerInitialBalance = 10000;

        Wallet CustomerWallet = new Wallet();
        public Customer(string Name, string BankNumber)
        {
            CustomerName = Name;
            CustomerAccountNumber = BankNumber;

        }
        public float Deposit(float amount)
        {
            CustomerWallet.balance += amount;
            return CustomerWallet.balance;
        }

        public float Withdraw(float amount)
        {
            CustomerWallet.balance -= amount;

            return CustomerWallet.balance;
        }

        public float BalanceInquiry()
        {
            return CustomerWallet.balance;
        }
    }
}