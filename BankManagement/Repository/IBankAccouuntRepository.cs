using BankManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Repository
{
    public interface IBankAccouuntRepository
    {
        IEnumerable<BankAccount> GetAllAccount();
        BankAccount GetAccountbyId(int customerId);
        BankAccount CreateAccount(BankAccount bankAccount);
        BankAccount UpdateAccount(BankAccount bankAccount);
        BankAccount DeleteAccount(int customerId);

    }
}
