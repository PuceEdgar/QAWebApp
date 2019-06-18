using MimeKit;
using MailKit.Net.Smtp;

namespace QAwebApp
{
    public class Email
    {

        public void Send()
        {
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("QA@web.app");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("example@somthing.something");
            message.To.Add(to);

            message.Subject = "This is a test email!";

            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "This is your new password: asfsdgfagsfg";

            message.Body = bodyBuilder.ToMessageBody();

            // MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            SmtpClient client = new SmtpClient();
            client.Connect("xxx", 25);

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();

        }
    }
}
