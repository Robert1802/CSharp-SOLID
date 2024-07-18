namespace D_Right
{
    public class SqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connection to Sql Database");
        }
    }
}
