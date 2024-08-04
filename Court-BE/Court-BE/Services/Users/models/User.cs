using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Court_BE.Services.Users.models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public User(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public User()
        {

        }
        public void SendMail(string numCase)
        {
            SmtpClient mySmtpClient = new SmtpClient("my.smtp.exampleserver.net");

            // set smtp-client with basicAuthentication
            mySmtpClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicAuthenticationInfo = new
               System.Net.NetworkCredential("username", "password");
            mySmtpClient.Credentials = basicAuthenticationInfo;

            // add from,to mailaddresses
            MailAddress from = new MailAddress("test@example.com", "TestFromName");

            try
            {

                MailAddress to = new MailAddress(mail, "TestToName");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);


                // set subject and encoding
                myMail.Subject = "Create Case num " + numCase;
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = $"<b>Hello  {name}</b><br>case number{numCase} opened  <b>Thank you</b>.";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SendMailToUsers errorr: " + ex.Message);
            }

        }
    }
}
