using System;
using System.Collections.Generic;
using System.IO;

namespace BootStrap.Store 
{
    class StoreData
    {
        private string _name;
        private string _surname;
        private string _email;
        private string _phone;
        private string _comment;
        private string _news;
        public StoreData(string name, string Surname, string Email, string Phone, string Comment, string news)
        {
            _name = name;
            _surname = Surname;
            _email = Email;
            _phone = Phone;
            _comment = Comment;
            _news = news;
        }
        // write the form data to a text file
        public void WriteFile()
        {
            string[] lines = { _name, _surname, _email, _phone, _comment, _news };
        
            System.IO.File.WriteAllLines(@"D:\Practice\Day1\ExitData.txt", lines);

        }
        // public function to validate form data 
        public Dictionary<string, bool> DataValidatorFilter()
        {
            Dictionary<string, bool> DataValidator = new Dictionary<string, bool>();
            
            bool option1 = string.IsNullOrEmpty(_name);
            bool option2 = string.IsNullOrEmpty(_surname);
            bool option3 = string.IsNullOrEmpty(_email);

            if( option1==false && option2==false && option3==false && option3==false )
            {    
                if(_name.Length < 200 && _surname.Length < 200 && _email.Length <200)
                {
                    DataValidator.Add("Requiered", true);        
                }else {
                    DataValidator.Add("Requiered", false); 
                }
            } else {
                DataValidator.Add("Requiered", false);
            }
            // Check the optional fileds if they are filed
            bool option4 = string.IsNullOrEmpty(_phone);
            
            if(option4 == false){
                
                if(_phone.Length <200 )
                {
                    DataValidator.Add("OptionalPhone", true);
                } else {
                    DataValidator.Add("OptionalPhone", false);
                }
            } else {
                DataValidator.Add("OptionalPhone", false);
            }
            bool option5 = string.IsNullOrEmpty(_comment);

            if( option5 == false ){
                
                if(_phone.Length <200 )
                {
                    DataValidator.Add("OptionalComment", true);
                } else {
                    DataValidator.Add("OptionalComment", false);
                }
            } else {
                DataValidator.Add("OptionalComment", false);
            }

            bool option6 = string.IsNullOrEmpty(_news);
            if( option6 == false){

                DataValidator.Add("OptionalNews", true);
            }
            else {
                DataValidator.Add("OptionalNews", false);
            }

            return DataValidator;
        }
    }
}