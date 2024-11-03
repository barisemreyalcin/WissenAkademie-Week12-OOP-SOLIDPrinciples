using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Person
    {
        public int PersonID {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; } 
        public string Email {  get; set; }

        public string UserName {  get; set; }
        public string Password { get; set; }

        public void SendEmaiResetPassword(string userName)
        {
            //TODO : Find User From UserName
            //int UserID = context.Users.GetUserFromUserName(userName);
            //string passwordResetLink = CreateLink(UserID);
            //SendMail(passwordResetLink);

            EmailService emailService = new EmailService();
            emailService.SendMail(new Person() { UserName = "johndoe", Email = "john.doe@contoso.com" });
        }
    }
}
