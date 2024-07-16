namespace L_Wrong
{
    public class SavingsAccount : Account
    {
        public override void Withdraw(double value)
        {
            if (Balance > value)
            {
                Balance -= value;
            }
        }
    }
}
