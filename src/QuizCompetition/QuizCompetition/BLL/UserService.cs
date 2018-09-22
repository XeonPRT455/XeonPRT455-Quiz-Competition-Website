using Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UserService : BaseService<t_user>, IUserService
    {
        private IUserDAL UserDAL = DAL.Container.Resolve<IUserDAL>();
        public override void SetDal()
        {
            Dal = UserDAL;
        }
    
    }
}
