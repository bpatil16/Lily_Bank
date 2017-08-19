using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class Bank
    {
        private static BankModel db = new BankModel();

        public static Account CreateAccount(string emailAddress, AccountTypes typeOfAccount, decimal amount = 0.0M)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                TypeOfAccount = typeOfAccount
            };
            if (amount > 0)
            {
                account.Deposit(amount);
            }
            db.Accounts.Add(account);
            //db.SaveChanges();
            return account;

        }

        public static Account [] GetAllAccountsByEmailAddress(string emailAddress)
            {
            return db.Accounts.Where(a => a.EmailAddress == emailAddress).ToArray();
            }

        public static Account GetAccountByAccountNumber(int accountNumber)
        {

            var account = db.Accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentException("Invalid Account Number");
            }

            return account;
        }

        public static void Deposit(int accountNumber, decimal amount)
        {
            var account = GetAccountByAccountNumber(accountNumber);
            account.Deposit(amount);
            db.Entry(account).CurrentValues.SetValues(account);
            db.SaveChanges();

            var transaction = new Transaction
            {
                TypeofTransaction = TransactionType.Credit,
                TransactionTime = DateTime.Now,
                Amount = amount,
                Description = "Deposit",
                AccountNumber = accountNumber
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();

        }


        }
        }


    }
}
