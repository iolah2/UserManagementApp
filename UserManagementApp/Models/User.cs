using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserManagementApp.Models
{
    //10 minutes
    public class User : ICSV
    {
        public User()
        {

        }

        public User(string rowFromCSV)
        {
            string[] userDatas = rowFromCSV.Split(';');
            try
            {
                if (userDatas.Length < 8)
                    throw new Exception("Any CSV row has not enough element for User!");
                ID = int.Parse(userDatas[0]);
                UserName = userDatas[1];
                Password = userDatas[2];
                LastName = userDatas[3];
                FirstName = userDatas[4];
                DateOfBirth = DateTime.Parse(userDatas[5]);
                PlaceOfBirth = userDatas[6];
                CityOfAddress = userDatas[7];
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured while reading data from file!\n"+ex.Message);///Is need to escape for any wrong data or send message?
            }
        }

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

        public string GetCSVRowFromItem()
        {
            return $"{ID};{UserName};{Password};{LastName};{FirstName};{DateOfBirth};{PlaceOfBirth};{CityOfAddress}";
        }
    }
}