using DevExpress.Export.Xl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using UserManagementApp.Models;

namespace UserManagementApp.Repositories
{
    class UserRepository: IRepository<User>, ILogin, IExport
    {
        public readonly string path = @"C:\Users\User\Source\Repos\2022\UserManagementApp\Users.csv";
        
        public IEnumerable<User> _userList;
        public IEnumerable<User> GetList()
        {
            if (_userList == null)
                RefreshList();
            return _userList;
        }

        public UserRepository()
        {
            RefreshList();
        }

        public bool Login(string userName, string password)
        {
            return _userList.FirstOrDefault(u=>u.UserName == userName)?.Password == password;
        }

        

        public void RefreshList()
        {
            List<User> users = new List<User>();
            //var g =  File.ReadAllLines(path);
            using (StreamReader sr = new StreamReader(path,Encoding.UTF8))
            {
                string dataRowCSV;
                while ((dataRowCSV = sr.ReadLine())!= null)
                {                    
                    try
                    {
                        users.Add( new User(dataRowCSV));
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error occured while reading data from file!");///Is need to escape for any wrong data or send message?
                    }
                }
            }
            _userList = users;
        }

        public User GetById(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            //int idx =_userList.ToList().IndexOf(_userList.ToList().First(u => u.ID == item.ID));
            List<string> lines = new List<string>();
            bool isFound = false;
            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string dataRowCSV;                
                while ((dataRowCSV = reader.ReadLine()) != null)
                {
                    if(dataRowCSV.Split(';')[0] == item.ID.ToString())
                    {
                        dataRowCSV = item.GetCSVRowFromItem();
                        isFound = true;
                    }
                    lines.Add(dataRowCSV);
                }
            }

            if (isFound)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }
            ///Use another step if allow adding new user!
            else throw new Exception("Not found updated user in csv file!");
            //TODO Here we need refresh
            GetList();
        }

        public bool Validate(User item)
        {
            throw new NotImplementedException();
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        public bool ExportDataList(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    return false;
                }
                else
                {
                    XDocument usersXDoc = new XDocument();
                    XElement userListXElement = new XElement("Users");
                    _userList.ToList().ForEach(u =>
                    {
                        XElement userXElement = new XElement("User",
                            new XElement("ID", u.ID),
                            new XElement("UserName", u.UserName),
                            new XElement("Password", u.Password),
                            new XElement("LastName", u.LastName),
                            new XElement("FirstName", u.FirstName),
                            new XElement("DateOfBirth", u.DateOfBirth),
                            new XElement("PlaceOfBirth", u.PlaceOfBirth),
                            new XElement("CityOfAddress", u.CityOfAddress));
                        userListXElement.Add(userXElement);
                    });
                    usersXDoc.Add(userListXElement);
                    usersXDoc.Save(filePath);
                    System.Diagnostics.Process.Start(filePath);
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Export user datas is unsuccess by error!");
            }
            //path;
            //return false;
        }
    }
}
