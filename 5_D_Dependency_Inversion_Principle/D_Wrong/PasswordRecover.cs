namespace D_Wrong
{
    public class PasswordRecover
    {
    private MySqlConnection? databaseConnection;
    public string RecoverPassword()
        {
            databaseConnection = new MySqlConnection();
            databaseConnection.Connect();
            // code to recover Password
            return "password";
        }
    }
}
