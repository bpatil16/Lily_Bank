using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Account
    {
        #region Properties
        /// <summary>
        /// Account number
        /// </summary>
        public int AccountNumber { get; }

        public string EmailAddress { get; set; }

        public decimal Balance { get; private set; }

        public string TypeOfAccount { get; set; }

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
