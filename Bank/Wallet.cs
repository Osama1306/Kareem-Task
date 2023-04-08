using System;
namespace BankSystem
{
    class Wallet
    {


        Transaction TransactionDetails = new Transaction();


        public string AccountNum = "";
        public string Name = "";
        private float Balance; //Private field Balance of user

        public Wallet()
        {

        }
        public Wallet(string InputName, string InputBankAccountNumber, float InitialBalance) //constructor to set values for Name , CardNum , and Balance
        {
            Name = InputName;
            AccountNum = InputBankAccountNumber;
            Balance = InitialBalance;

        }
        public float balance //Public property to set and get balance
        {
            get
            {
                return Balance;
            }
            set
            {
                //condition for cash deposit
                if (TransactionDetails.TypeOfTransaction == "deposit")
                {
                    Balance += CashGained(TransactionDetails);
                }
                //else it will be withdraw
                else
                {
                    Balance += CashDeducted(TransactionDetails);
                }

            }
        }

        public float CashGained(Transaction TransactionGiven)
        {
            return TransactionGiven.Amount;
        }
        public float CashDeducted(Transaction TransactionGiven)
        {
            return -(TransactionGiven.Amount);
        }










    }
}