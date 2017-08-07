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

            Console.WriteLine("******************* Welcome to BedRock Bank! ******************");
            while (true)
            {
                Console.Write("Please select from the following options");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        Console.WriteLine("\n Thank you!");
                        return;
                    case "1":
                        Console.Write("\nPlease provide email address: ");
                        var emailAddress = Console.ReadLine();
                        Console.Write("\n What Type of Account: ");

                        var typeOfAccounts = Enum.GetNames(typeof(AccountTypes));
                        for (int i = 0; i < typeOfAccounts.Length; i++)
                        {
                            Console.WriteLine($"{i+1}:{typeOfAccounts[i]}");
                        }

                        var typeOfAccount = Convert.ToInt32(Console.ReadLine());
                        var accountType = (AccountTypes)Enum.Parse(typeof(AccountTypes),
                            typeOfAccounts[typeOfAccount-1]);

                        Console.Write("Amount to deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                        var account1 = Bank.CreateAccount(emailAddress, accountType, amount);
                        Console.WriteLine($"AccountNumber: {account1.AccountNumber}, TypeOfAccount: {account1.TypeOfAccount}, Balance: {account1.Balance}");


                        break;
                    case "2":
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
