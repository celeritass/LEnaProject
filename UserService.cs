using Lena.Service.Base;
using LenaProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.Service.Option
{
    public class UserService : BaseService<User>
    {
         public bool CheckCredentials(string username, string password)
        {
            return Any(x=>x.UserName==username && x.Password == password); // kullanıcı adı doğru mu
        }
        public User FindByUserName (string username) // kullanıcı adına göre kullanıcıları listeleyecek.?? lazım mı
        {
            return GetByDefault(x => x.UserName == username);
        }
    }
}
