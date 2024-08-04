using Court_BE.Services.LegalCases.models;
using Court_BE.Services.Users.models;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Court_BE.Services.Users
{
    public class Users
    {
        //private readonly IEntityRepository<Case, int> _userRepository;
   
    
        void SendMailToUsers(List<User> users, string numCase)
        {
            foreach (User user in users)
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

                       MailAddress to = new MailAddress(user.mail, "TestToName");
                       MailMessage myMail = new System.Net.Mail.MailMessage(from, to);


                    // set subject and encoding
                    myMail.Subject = "Create Case num "+numCase;
                    myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                    // set body-message and encoding
                    myMail.Body = $"<b>Hello  {user.name}</b><br>case number{numCase} opened  <b>Thank you</b>.";
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
}
