using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_12.Interfaces
{
    public interface ITransferManager<in T>
    {
        void Transfer(T sender, T receiver, decimal amount);
    }
}
