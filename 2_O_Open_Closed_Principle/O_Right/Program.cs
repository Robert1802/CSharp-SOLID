namespace O_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            Request commonCustomer = new Request();
            Request associateCustomer = new AssociateCustomerDiscount();
            Request specialCustomer = new SpecialCustomerDiscount();
            Request vipCustomer = new VIPCustomerDiscount();

            double commonCUstomerRequestValue =
                commonCustomer.RequestDiscount(1000);

            double associateCustomerRequestValue =
                associateCustomer.RequestDiscount(1000);

            double specialCustomerRequestValue =
                specialCustomer.RequestDiscount(1000);

            double vipCustomerRequestValue =
                vipCustomer.RequestDiscount(1000);


            Console.WriteLine($"Common Customer = " +
                $"{commonCUstomerRequestValue}");

            Console.WriteLine($"Associate Customer = " +
                $"{associateCustomerRequestValue}");

            Console.WriteLine($"Special Customer = " +
                $"{specialCustomerRequestValue}");

            Console.WriteLine($"VIP Customer = " +
               $"{vipCustomerRequestValue}");

            Console.ReadLine();
        }
    }
}
