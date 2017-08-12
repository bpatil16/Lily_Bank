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
    }
}
