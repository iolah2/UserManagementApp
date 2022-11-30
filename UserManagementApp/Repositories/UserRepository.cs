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
                while (!sr.EndOfStream)
                {
                    string[] userDatas = sr.ReadLine().Split(';');
                    try
                    {
                        users.Add(
                            new User()
                            {
                                ID = int.Parse(userDatas[0]),
                                UserName = userDatas[1],
                                Password = userDatas[2],
                                LastName = userDatas[3],
                                FirstName = userDatas[4],
                                DateOfBirth = DateTime.Parse(userDatas[5]),
                                PlaceOfBirth = userDatas[6],
                                CityOfAddress = userDatas[7]
                            }
                            );
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
            throw new NotImplementedException();
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
