using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.Extensions.Configuration;

namespace BootStrap.Store 
{
    class SendEmail
    {
        private string _name;
        private string _surname;
        private string _email;
        private string _phone;
        private string _comment;
        private string _news;
        public string SendgridKey { get; set; }
        private IConfiguration configuration;

        public SendEmail(string name, string Surname, string Email, string Phone, string Comment, string news)
        {
            _name = name;
            _surname = Surname;
            _email = Email;
            _phone = Phone;
            _comment = Comment;
            _news = news;
        
        }
       
        public void TestEmail()
        {
            string test1 = configuration.GetSection("MySettings").GetSection("SENDGRID_API_KEY").Value;
            Console.Write(test1);
        }
    }
}