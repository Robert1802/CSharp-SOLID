namespace O_Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request1 = new Request();

            var commonCustomerRequestValue =
               request1.DiscountRequest(1000, CustomerType.Common);

            var associateCustomerRequestValue =
                request1.DiscountRequest(1000, CustomerType.Associate);

            var specialCustomerRequestValue =
                request1.DiscountRequest(1000, CustomerType.Special);

            Console.WriteLine("OCP Principle - Violation");

            Console.WriteLine($"Common Customer = " +
                $"{commonCustomerRequestValue}");

            Console.WriteLine($"Associate Customer = " +
                $"{associateCustomerRequestValue}");

            Console.WriteLine($"Special Customer = " +
                $" {specialCustomerRequestValue}");

            Console.ReadLine();
        }
    }
}
