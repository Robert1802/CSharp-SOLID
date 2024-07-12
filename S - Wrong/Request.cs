using System.Net.Mail;

namespace S_Wrong
{
    class Request
    {
        public long Quantity { get; set; }
        public DateTime Date { get; set; }
        public void IncludeRequest()
        {
            try
            {
                // Code to include Request
                // After including, send the email
                MailMessage mailMessage =
                    new MailMessage("EMailFrom", "EMailTo",
                              "EMailSubject", "EMailBody");

                this.SendEmailRequest(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteRequest()
        {
            try
            {
                // Code to delete the generated order
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", ex.ToString());
            }
        }
        public void SendEmailRequest(MailMessage mailMessage)
        {
            try
            {
                // Code to send configure
                // email and send the order email
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"c:\data\ErrorLog.txt", ex.ToString());
            }
        }
    }
}
