using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BootStrap.Store;
using SendGrid;
using SendGrid.Helpers.Mail;


namespace BootStrap.Pages
{
    public class ContactModel : PageModel
    {
       [BindProperty]
       public string name {get; set;}
       [BindProperty]
       public string surname {get;set;}
       [BindProperty]
       public string  email {get;set;}
       [BindProperty]
       public string phone {get;set;}
       [BindProperty]
       public string comment {get;set;}
       [BindProperty]
       public string news {get;set;}


        public void OnPost()
        {
            var emailsend = new SendEmail(name, surname, email, phone, comment, news); 
            var StoreData = new StoreData(name, surname, email, phone, comment, news); 
            StoreData.WriteFile();
            var DataValidator = StoreData.DataValidatorFilter();

            if (DataValidator["Requiered"] == true){
                // send success message
                // store data
                emailsend.TestEmail();

            } else {
                // send error message
            }
            if (DataValidator["OptionalPhone"] == true){
                // store phone
            }
            if (DataValidator["OptionalComment"] == true){
                // store comment
            }
            if (DataValidator["OptionalNews"] == true) {
                // store that client wants to inform he about next offers
            } 
        }

       
    }
}