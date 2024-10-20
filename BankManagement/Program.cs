using BankManagement.Entities;
using BankManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Program
    {
        public static BankAccouuntRepository accountRepo = new BankAccouuntRepository();
        static void Main(string[] args)
        {
			try
			{
                Dotask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }
        }

        private static void Dotask()
        {
            Console.WriteLine("\t\t\t\tBank Management\r");
            Console.WriteLine("\t\t\t\t--------------------\n");
            Console.WriteLine("\t\tHow many operation would you like to perform?\n");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\t\t\t\tSelect Operation\n");
                    Console.WriteLine("\t\tHint: \nShow -1\nCreate -2\nUpdate -3\nDelete -4");
                    int openCount = Convert.ToInt32(Console.ReadLine());
                    switch (openCount)
                    {
                        case 1: ShowAccount(null); break;
                        case 2: CreateAccount();   break;
                        case 3: UpdateAccount();   break;
                        case 4: DeleteAccount();   break;
                        default: Console.WriteLine("invalid operation");break;
                    }
                }
            }
        }

        private static void DeleteAccount()
        {
            BankAccount deleteAccount = new BankAccount();
            deleteAccount.CustomerId = 5;
            deleteAccount = accountRepo.DeleteAccount(deleteAccount.CustomerId);

            Console.WriteLine("Deleted Successfully");
            ShowAccount(deleteAccount);
        }

        private static void UpdateAccount()
        {
            BankAccount upAccount = new BankAccount();
            upAccount.CustomerId = 4;
            upAccount.CustomerName = "Zunayed Ahmed";
            upAccount.CustomerEmail = "zunayed002@gmail.com";
            upAccount.CustomerAddress = "Mohammadpur,Dhaka";
            upAccount.AccountNumber = 852137;
            upAccount.Balance = 300000;
            upAccount.Type = AccountType.Savings;           
            upAccount = accountRepo.UpdateAccount(upAccount);
            ShowAccount(upAccount);
           
        }

        private static void CreateAccount()
        {
            BankAccount account = new BankAccount(6, "Tushar Mondol", "tusharali@yahoo.com", "Nagarbari,Rajshahi", 852369, 700000, AccountType.Business);
            accountRepo.CreateAccount(account);
            Console.WriteLine(" Added Successfully");
            ShowAccount(account);
        }

        private static void ShowAccount(BankAccount account)
        {
           
            IEnumerable<BankAccount> bankAccounts = accountRepo.GetAllAccount();
            Console.WriteLine(string.Format("|{0,5}| {1,10}| {2,-20}|  {3,10}| {4,10}| {5,20}",
               "CustomerId", "CustomerName", "CustomerAddress", "Account Number", "Balance", "Account Type"));
            Console.WriteLine();
            if (account == null)
            {
                foreach (BankAccount item in bankAccounts)
                {
                    Console.WriteLine(string.Format("|{0,5}| {1,10}| {2,-20}|  {3,10}| {4,10}| {5,20}",
                       item.CustomerId, item.CustomerName,item.CustomerAddress,item.AccountNumber,item.Balance,item.Type));
                }
            }
            else
            {
                Console.WriteLine(string.Format("|{0,5}| {1,10}| {2,-20}|  {3,10}| {4,10}| {5,20}",
                    account.CustomerId ,account.CustomerName, account.CustomerAddress, account.AccountNumber, account.Balance, account.Type));
            }
            Console.WriteLine();
        }
    }
}
