using Microsoft.AspNetCore.Identity.UI.Services;

namespace BookShop.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //Implement how to send email
            return Task.CompletedTask;
        }
    }
}
