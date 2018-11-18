using System;

namespace azure_test.Application.Models
{
    public class User {
        public string Name {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public User(string name, string email, string password) {
            Email = email;
            Name = name;
            Password = password;

            validate();
        }

        public User() {
            
        }

        bool validate() {
            Console.WriteLine("successfully validated a new user ;p");
            return true;
        }
    }
    
}