namespace I_Wrong
{
    internal class RegisterClient : IPersistency
    {

        public void ValidateData()
        {
            Console.WriteLine("Validate Data");
        }

        public void SaveDataBase()
        {
            Console.WriteLine("Save Data");
        }

        public void SendEmail()
        {
            Console.WriteLine("Send Email");
        }
    }
}
