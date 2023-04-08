using System;
using System.Collections;
namespace BankSystem
{
    class Terminal
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Choose Your Position:");
            Console.WriteLine("1)Client");
            Console.WriteLine("2)Admin");
            Console.WriteLine("1)Partner");
            int response1 = int.Parse(Console.ReadLine());
            if (response1 == 1)
            {
                System.Console.WriteLine("Enter Your Name:");
                string EnteredName = Console.ReadLine();
                System.Console.WriteLine("Enter Your Account Number:");
                string EnteredBankNumber = Console.ReadLine();
                Customer customer1 = new Customer(EnteredName, EnteredBankNumber);

                Console.WriteLine("Choose The Operation You want:");
                Console.WriteLine("1-Deposit");
                Console.WriteLine("2-Witdhraw");
                Console.WriteLine("3-Balance Inquiry");
                int response2 = int.Parse(Console.ReadLine());
                if (response2 == 1)
                {
                    System.Console.WriteLine("This deposit is for? \n 1)My Account \n 2)Partner");
                    int response3 = int.Parse(Console.ReadLine());
                    if (response3 == 1)
                    {
                        System.Console.WriteLine("Enter the amount you want to deposit:");
                        customer1.Deposit(float.Parse(Console.ReadLine()));

                    }
                }
            }



















        }
    }
}