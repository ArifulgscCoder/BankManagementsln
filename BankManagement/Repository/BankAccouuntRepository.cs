using BankManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Repository
{
    public class BankAccouuntRepository : IBankAccouuntRepository
    {
        private List<BankAccount> accountList;

        public BankAccouuntRepository()
        {
            accountList = new List<BankAccount>()
            {
            new BankAccount() {CustomerId =1, CustomerName = "Ariful Islam", CustomerEmail = "arifulgsc01@gmail.com",   CustomerAddress = "Tangail,Dhaka",      AccountNumber=123456,Balance=500000, Type=AccountType.Savings },
            new BankAccount() {CustomerId =2, CustomerName = "Monir Khan",   CustomerEmail = "monirgsc@gmail.com",      CustomerAddress = "Tangail,Dhaka",      AccountNumber=741236,Balance=600000, Type=AccountType.Business },
            new BankAccount() {CustomerId =3, CustomerName = "Noble Sheikh", CustomerEmail = "noble002@gmail.com",      CustomerAddress = "Kolabagan,Dhaka",    AccountNumber=963214,Balance=400000, Type=AccountType.Checking },
            new BankAccount() {CustomerId =4, CustomerName = "Zunayed khan", CustomerEmail = "zunayedkhan2@gmail.com",  CustomerAddress = "Mohammadpur,Dhaka",  AccountNumber=852136,Balance=300000, Type=AccountType.Savings },
            new BankAccount() {CustomerId =5, CustomerName = "Kawser Ahmed", CustomerEmail = "kawser152@gmail.com",     CustomerAddress = "Mirpur,Dhaka",       AccountNumber=258796,Balance=400000, Type=AccountType.Checking }
            };
        }

        public IEnumerable<BankAccount> GetAllAccount()
        {
            return from rows in accountList select rows;
        }
        
        public BankAccount CreateAccount(BankAccount bankAccount)
        {
            BankAccount exitingAcoount=((from a in accountList orderby a.CustomerId descending select bankAccount).Take(1)).Single() as BankAccount;
            bankAccount.CustomerId = exitingAcoount.CustomerId + 1;
            accountList.Add(bankAccount);
            return bankAccount;
        }

        public BankAccount DeleteAccount(int customerId)
        {
            BankAccount deleteAccount = GetAccountbyId(customerId);
            if (deleteAccount != null)
            {
                accountList.Remove(deleteAccount);
            }
            return deleteAccount;

        }

        public BankAccount GetAccountbyId(int customerId)
        {
            var bankAccount=(from a in accountList where a.CustomerId == customerId select a).Single();
            return bankAccount as BankAccount;
        }

        

        public BankAccount UpdateAccount(BankAccount upAccount)
        {
            BankAccount upbankAccount = GetAccountbyId(upAccount.CustomerId);
            if (upbankAccount != null)
            {
                upbankAccount.CustomerId = upAccount.CustomerId;
                upbankAccount.CustomerName = upAccount.CustomerName;
                upbankAccount.CustomerEmail = upAccount.CustomerEmail;
                upbankAccount.CustomerAddress = upAccount.CustomerAddress;
                upbankAccount.AccountNumber = upAccount.AccountNumber;
                upbankAccount.Balance = upAccount.Balance;
                upbankAccount.Type = upAccount.Type;                
            }
            return upbankAccount;

        }
    }
}
