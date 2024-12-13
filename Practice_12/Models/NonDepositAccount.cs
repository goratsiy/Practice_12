namespace Practice_12.Models
{
    [Serializable]
    public class NonDepositAccount : Account
    {
        public NonDepositAccount() : base() { }

        public NonDepositAccount(decimal initialBalance) : base("NonDeposit", initialBalance) { }
    }
}
