namespace D_Right
{
    public class MySqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Connection to MySql Database");
        }
    }
}
