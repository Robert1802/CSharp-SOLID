namespace O_Right
{
    internal class VIPCustomerDiscount : Request
    {
        public override double RequestDiscount(double finalValue)
        {
            return finalValue - 100;
        }
    }
}