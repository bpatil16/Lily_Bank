using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public enum AccountTypes
     {
        Checking,
        Savings,
        Loan,
        CD
     }

    public class Account
    {
        #region static Variables

        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; private set; } 

        public DateTime CreatedDate { get; private set; }
        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }

        
        public AccountTypes TypeOfAccount { get; set; }

        #endregion
        
        #region Constructor


        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion
        #region Methods

        public void Deposit(decimal amount)
        {
            Balance+= amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion 
    }
}
