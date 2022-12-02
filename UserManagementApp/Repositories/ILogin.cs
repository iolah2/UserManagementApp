using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementApp.Repositories
{
    public interface ILogin
    {
        bool IsUserListEmpty();
        bool Login(string userName, string password);
    }
}
