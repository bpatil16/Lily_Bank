using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new Account();
            account1.EmailAddress = "test@test.com";
            account1.TypeOfAccount = "Checking";
            account1.Deposit(100.40M);
            Console.WriteLine($"AccountNumber: {account1.AccountNumber}, TypeOfAccount: {account1.TypeOfAccount}, Balance: {account1.Balance}");
            Console.ReadLine();

        }
    }
}
