namespace L_Right
{
    public class SavingsAccount : Account
    {
        public override double Balance { get; set; }
        public void Withdraw(double value)
        {
            if (Balance > value)
            {
                Balance -= value;
            }
        }
    }
}
