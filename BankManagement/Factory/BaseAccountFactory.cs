using BankManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Factory
{
    public abstract class BaseAccountFactory
    {
        BankAccount bankAccount;
        protected BaseAccountFactory() { }
    }
}
