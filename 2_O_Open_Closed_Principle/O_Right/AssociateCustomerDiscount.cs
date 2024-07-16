namespace O_Right
{
    internal class AssociateCustomerDiscount : Request
    {
        public override double RequestDiscount(double finalValue)
        {
            return finalValue - 10;
        }
    }
}