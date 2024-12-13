using System;
using System.Xml.Serialization;

namespace Practice_12.Models
{
    [Serializable]
    public abstract class Account
    {
        [XmlAttribute]
        public Guid AccountNumber { get; set; } = Guid.NewGuid();

        [XmlElement]
        public decimal Balance { get; set; }

        [XmlElement]
        public string AccountType { get; set; }

        // Пустой конструктор для сериализации
        protected Account() { }

        protected Account(string accountType, decimal initialBalance = 0)
        {
            AccountType = accountType;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be greater than zero.");
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance) throw new ArgumentException("Invalid withdrawal amount.");
            Balance -= amount;
        }
    }
}
