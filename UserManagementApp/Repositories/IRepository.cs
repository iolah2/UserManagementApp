using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApp.Repositories
{
    public interface IRepository<T> where T : class
    {        
        IEnumerable<T> GetList();
        void RefreshList();
        T GetById(object id);
        //void Insert(T item);
        void Update(T item);
        bool Validate(T item);
        //void Delete(object id);
        void Save(T item);
    }
}

