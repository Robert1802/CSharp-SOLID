namespace I_Wrong
{
    internal class RegisterProduct : IPersistency
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
            // Not necessary to Implement!!
            throw new NotImplementedException();
        }
    }
}
