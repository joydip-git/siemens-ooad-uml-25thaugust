using System.Net.Mail;

namespace SRPApp
{
    public class EmailService
    {
        private readonly SmtpClient smtpClient;

        public EmailService()
        {
            this.smtpClient = new();
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public void SendEmail(MailMessage mail)
        {
            smtpClient.Send(mail);
        }
    }
}