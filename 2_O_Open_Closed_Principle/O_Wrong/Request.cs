namespace O_Wrong
{
    public enum CustomerType
    {
        Common,
        Associate,
        Special
    };
    class Request
    {
        //...other code
        public double DiscountRequest(double value, CustomerType customerType)
        {
            double finalValue;

            if (customerType == CustomerType.Special)
            {
                finalValue = value - 50;
            }
            else if (customerType == CustomerType.Associate)
            {
                finalValue = value - 10;
            }
            else
            {
                finalValue = value;
            }
            return finalValue;
        }
    }
}
