namespace O_Right
{
    internal class SpecialCustomerDiscount : Request
    {
        public override double RequestDiscount(double finalValue)
        {
            return finalValue - 50;
        }
    }
}