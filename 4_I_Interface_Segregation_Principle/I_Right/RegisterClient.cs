namespace I_Right
{
    internal class RegisterClient : IPersistency, IMessageEmail
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
