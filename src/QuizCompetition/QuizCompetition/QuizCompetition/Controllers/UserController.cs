using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using QuizCompetition.DTO;
using AutoMapper;

namespace QuizCompetition.Controllers
{
    /// <summary>
    /// This is UserController
    /// </summary>
    public class UserController : ApiController
    {
        private IUserService UserService = BLL.Container.Resolve<IUserService>();
        // GET api/user
        public List<t_user> Get()

        {
            List<t_user> list = UserService.GetModels(p => true).ToList();
            return list;
        }

        // GET api/user/5
        public UserDTO Get(int id)

        {
           
            var user = UserService.Load(id);

            var dto = Mapper.Map<UserDTO>(user);
            return dto;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/user/5
        public void Delete(int id)
        {
            UserService.DeleteUser(id);
        }

    }
}
