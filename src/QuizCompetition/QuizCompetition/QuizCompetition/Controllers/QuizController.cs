using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuizCompetition.Controllers
{
    public class QuizController : ApiController
    {
        // GET: api/Quiz
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Quiz/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Quiz
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Quiz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Quiz/5
        public void Delete(int id)
        {
        }
    }
}
