using DevExpress.Export.Xl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using UserManagementApp.Models;

namespace UserManagementApp.Repositories
{
    public class UserRepository : IRepository<User>, ILogin, IExport
    {


        //Todo create an example csv if not exists
        public readonly string path = Path.Combine(Environment.CurrentDirectory, "Users.csv");

        public /*ObservableCollection<User>*/List<User> _userList;
        private User _actUser;

        public User AktItem => _actUser;

        public /*ObservableCollection<User>*/List<User> GetList()
        {
            /*if (_userList == null)
                RefreshList();*/
            return _userList.OrderBy(t => t.ID).ToList();
        }

        public UserRepository()
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                    WriteTestingDataIntoCsv(path);
                }
                RefreshList();
            }
            catch
            {
                throw new Exception("Hiba az adatkapcsolat létrehozása során!");
            }
        }

        private void WriteTestingDataIntoCsv(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("1;Antilop;Korte;Kiss;Géza;1997.12.30;Szeged;Algyő;");
                    writer.WriteLine("2;Kenu;Szilva;Nagy;Andrea;1975.02.11;Pest;Buda;");
                    writer.WriteLine("3;Teve;Palesz;Kiss;Géza;1964.01.23;Szolnok;Pécs;");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #region Login part
        public bool IsUserListEmpty() => !(_userList?.Count() > 0);

        public bool Login(string userName, string password)
        {
            return _userList
                .FirstOrDefault(u => u.UserName == userName)?
                .Password == password;
        }
        #endregion


        /// <summary>
        /// Firstly Set drop error if resource file have wrong row for get user.
        /// We can count rows that is in wrong format instead of drop error if any bad row.
        /// </summary>
        public void RefreshList()
        {
            List<User> users = new List<User>();
            //int countBadRow = 0;
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string dataRowCSV;
                while ((dataRowCSV = sr.ReadLine()) != null)
                {
                    try
                    {
                        users.Add(new User(dataRowCSV));
                    }
                    catch
                    {
                        //countBadRow++;
                        throw new Exception("A felhasználók listázása során hiba történt!");///Is need to escape for any wrong data or send message?
                    }
                }
            }
            //if(countBadRow>0)                
            _userList = users;
        }

        //Todo: Exception - új felhasználó esetén a végére kell írni az újat + új id
        //A throw ág helyett.
        public string Update()
        {
            string msg = _actUser.ValidateWithErrorMsg();
            if (msg is null)
            {
                //int idx =_userList.ToList().IndexOf(_userList.ToList().First(u => u.ID == item.ID));
                List<string> lines = new List<string>();
                bool isFound = false;
                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    string dataRowCSV;
                    while ((dataRowCSV = reader.ReadLine()) != null)
                    {
                        if (dataRowCSV.Split(';')[0] == _actUser.ID.ToString())
                        {
                            dataRowCSV = _actUser.GetCSVRowFromItem();
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
                else throw new Exception("A módosított felhasználó nem található az adatbázisban!");
                //TODO Here we need refresh
                GetList();
            }
            return msg;
        }



        public void ExportDataList(string filePath)
        {
            try
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
            }
            catch (Exception ex)
            {
                throw new Exception($"Felhasználók xml exportja sikertelen!\nA(z) {filePath} nem jött létre!");
            }
        }

        //public void StartEdit()
        //{
        //    _actUser.StartEdit();
        //}

        //public void ResetUserOld()
        //{
        //    _actUser.ResetUserOld();
        //}

        public bool SetActItemById(int ID)
        {
            _actUser = _userList.FirstOrDefault(u => u.ID == ID);
            return _actUser?.ID == ID;//TODO another testing
        }
    }
}
