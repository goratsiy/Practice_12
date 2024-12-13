namespace Practice_12.Models
{
    [Serializable]
    public class DepositAccount : Account
    {
        public DepositAccount() : base() { }

        public DepositAccount(decimal initialBalance) : base("Deposit", initialBalance) { }
    }
}
