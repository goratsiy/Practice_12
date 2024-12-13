using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_12.Models;

namespace Practice_12.Interfaces
{
    public interface IAccountManager<out T> where T : Account
    {
        T CreateAccount(decimal initialBalance);
    }

}
