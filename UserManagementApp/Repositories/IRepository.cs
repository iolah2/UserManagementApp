using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApp.Repositories
{
    public interface IRepository<T> where T : class
    {
        T AktItem { get; }//GetActItem();
        bool SetActItemById(int ID); 
        List<T> GetList();
        void RefreshList();
        //T GetById(object id);
        //void Insert(T item);
        string Update();
        //void StartEdit();
        //void ResetUserOld();
    }
}

