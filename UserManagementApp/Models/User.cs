using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserManagementApp.Models
{
    //10 minutes
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        ///Store as Hashed or original? - on controlling login
        ///In first round without hashing - I have no information from password and hashed password too.
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CityOfAddress { get; set; }
    }
}