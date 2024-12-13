using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Practice_12.Models
{
    [Serializable]
    public class Client
    {
        [XmlAttribute]
        public Guid ClientId { get; set; } = Guid.NewGuid();

        [XmlElement]
        public string FullName { get; set; }

        [XmlArray]
        public List<Account> Accounts { get; set; } = new List<Account>();

        // Пустой конструктор для сериализации
        public Client() { }

        public Client(string fullName)
        {
            FullName = fullName;
        }

        public void AddAccount(Account account)
        {
            if (Accounts.Exists(a => a.GetType() == account.GetType()))
                throw new InvalidOperationException("A client can only have one account of each type.");
            Accounts.Add(account);
        }
    }
}
