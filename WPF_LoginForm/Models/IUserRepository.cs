using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WPF_LoginForm.Model;

namespace WPF_LoginForm.Models
{
    public interface IUserRepository
    {
        bool Authenticateuser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetUsername(string username);
        IEnumerable<UserModel> GetByAll();
        bool AuthenticateUser(NetworkCredential networkCredential);
        object GetByUsername(string name);
        object GetByUsername(IPrincipal currentPrincipal);
    }
}




