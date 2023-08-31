using System.ComponentModel.DataAnnotations;
using System.Net.Mail;


namespace SRPApp
{
    public class UserService
    {
        private readonly EmailService emailService;

        public UserService(EmailService emailService)
        {
            this.emailService = emailService;
        }

        public void RegisterUser(string email, string password)
        {
            if (!this.emailService.ValidateEmail(email))
                throw new ValidationException("Invalid email");

            var user = new User { UserName = email, Password = password };
            this.emailService.SendEmail(new MailMessage("abcd@gmail.com", email) { Subject = "" });
        }
    }
}