using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizCompetition.Controllers
{
   // [Authorize]
    public class ValuesController : ApiController
    {
        private IUserService UserService = BLL.Container.Resolve<IUserService>();
        // GET api/values
        public List<t_user> Get()

        {
            List<t_user> list = UserService.GetModels(p => true).ToList();
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            var user = UserService.GetModels(p => p.UserId == id).FirstOrDefault();
            String name = user.NickName;
            return name;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
