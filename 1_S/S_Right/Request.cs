namespace S_Right
{
    class Request
    {
        public long Quantity { get; set; }
        public DateTime Date { get; set; }
        private Ilogger infoLogger;
        private SendEmail sendEmail;
        public Request()
        {
            sendEmail = new SendEmail();
            infoLogger = new RegisterLog();
        }
        public void IncludeRequest()
        {
            try
            {
                infoLogger.Info("Includes a Request");
                sendEmail.EMailFrom = "emailfrom@xyz.com";
                sendEmail.EMailTo = "emailto@xyz.com";
                sendEmail.EMailSubject = "SRP";
                sendEmail.EMailBody = "Um";
                sendEmail.Send();
            }
            catch (Exception ex)
            {
                infoLogger.Info("Error sending email : " + ex.Message);
            }
        }
        public void DeletaRequest()
        {
            try
            {
                // Code to delete the generated order
                infoLogger.Info("Request deleted in " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Error when deleting order " + ex.Message);
            }
        }
    }
}
