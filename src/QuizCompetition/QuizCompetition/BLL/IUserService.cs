using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IUserService: IBaseService<t_user>
    {
         t_user Load(int id);

         void AddUser(t_user user);

        void UpdateUser(t_user user);

        void UpdatePwd(int uid, String oldPwd, String newPwd);

        t_user Login(String username, String password);

        void DeleteUser(int id);


    }
}
