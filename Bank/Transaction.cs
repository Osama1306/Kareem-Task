using System;
namespace BankSystem
{
    class Transaction
    {
        public DateTime TimeOfTransaction = DateTime.Now;
        public float Amount;
        public string TypeOfTransaction = "";
        public string AccountNumber = "";

        public Transaction() { }

        public Transaction(float amount, string type, string accountNumber)
        {
            Amount = amount;
            TypeOfTransaction = type;
            AccountNumber = accountNumber;
        }


    }



}