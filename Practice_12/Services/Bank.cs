using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_12.Interfaces;
using Practice_12.Models;

namespace Practice_12.Services
{
    public class Bank : IAccountManager<Account>, ITransferManager<Client>
    {
        public List<Client> Clients { get; set; } = new List<Client>();

        public Client AddClient(string fullName)
        {
            var client = new Client(fullName);
            Clients.Add(client);
            return client;
        }

        public Account CreateAccount(decimal initialBalance)
        {
            return new NonDepositAccount(initialBalance);
        }

        public void Transfer(Client sender, Client receiver, decimal amount)
        {
            if (sender == null || receiver == null) throw new ArgumentNullException("Sender or receiver cannot be null.");

            var senderAccount = sender.Accounts.FirstOrDefault();
            var receiverAccount = receiver.Accounts.FirstOrDefault();

            if (senderAccount == null || receiverAccount == null)
                throw new InvalidOperationException("Both clients must have accounts.");

            senderAccount.Withdraw(amount);
            receiverAccount.Deposit(amount);
        }
    }
}
