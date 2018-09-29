using Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.utils;

namespace BLL
{
    public class UserService : BaseService<t_user>, IUserService
    {
        private IUserDAL UserDAL = DAL.Container.Resolve<IUserDAL>();
        public override void SetDal()
        {
            Dal = UserDAL;
        }



        public t_user Load(int id)
        {
            return GetModels(p => p.UserId == id).FirstOrDefault();
        }


        public void AddUser(t_user user)
        {
            var tu = GetModels(p => p.UserName == user.UserName).FirstOrDefault(); ;
            if (tu != null) throw new QCException("The added user object already exists and cannot be added");
            user.CreateDate = new DateTime();
            try
            {
                user.PassWord = SecurityUtil.MD5Encoding(user.UserName, user.PassWord);
            }
            catch (Exception e)
            {
                throw new QCException("Password encryption failed:" + e.Message);
            }
            UserDAL.Add(user);


        }


        public void UpdateUser(t_user user)
        {
            Update(user);
        }



        public void UpdatePwd(int uid, String oldPwd, String newPwd)
        {
            try
            {
                var u = Load(uid);
                if (!SecurityUtil.MD5Encoding(u.UserName, oldPwd).Equals(u.PassWord))
                {
                    throw new QCException("The original password is incorrect");
                }
                u.PassWord=SecurityUtil.MD5Encoding(u.UserName, newPwd);
                Update(u);
            }
            catch (Exception e)
            {
                throw new QCException("Update password failed:" + e.Message);
            }
        }


        public t_user Login(String username, String password)
        {
            var user = GetModels(p => p.UserName == username).FirstOrDefault();
            if (user == null) throw new QCException("User name or password is incorrect");
            try
            {
                if (!SecurityUtil.MD5Encoding(username, password).Equals(user.PassWord))
                {
                    throw new QCException("User name or password is incorrect");
                }
            }
            catch (Exception e)
            {
                throw new QCException("Password encryption failed:" + e.Message);
            }

            return user;
        }


        public void DeleteUser(int id)
        {


            var user = Load(id);
            Delete(user);
        }
    }
}
