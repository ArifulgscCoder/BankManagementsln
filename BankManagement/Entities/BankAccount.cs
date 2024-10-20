using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Entities
{
    public class BankAccount
    {
        int customerId;
        string customerName;
        string customerEmail;
        string customerAddress;
        int accountNumber;
        decimal balance;
        AccountType type;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string CustomerEmail { get => customerEmail; set => customerEmail = value; }
        public string CustomerAddress { get => customerAddress; set => customerAddress = value; }
        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public AccountType Type { get => type; set => type = value; }

        public BankAccount(int customerId, string customerName, string customerEmail, string customerAddress, int accountNumber, decimal balance, AccountType type)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.CustomerEmail = customerEmail;
            this.CustomerAddress = customerAddress;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Type = type;
        }
        public BankAccount()
        {
            
        }
    }
}
