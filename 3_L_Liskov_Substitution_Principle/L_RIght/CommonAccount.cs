namespace L_Right
{
    public class CommonAccount : Account
    {
        public override double Balance { get; set; }
        public void Withdraw(double value)
        {
            Balance -= value;
        }
    }
}
