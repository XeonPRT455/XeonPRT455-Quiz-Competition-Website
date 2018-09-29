using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Model;

namespace QuizCompetition.Controllers
{
    public class t_userController : ApiController
    {
        private QuizCompetitionEntities db = new QuizCompetitionEntities();

        // GET: api/t_user
        public IQueryable<t_user> Gett_user()
        {
            return db.t_user;
        }

        // GET: api/t_user/5
        [ResponseType(typeof(t_user))]
        public async Task<IHttpActionResult> Gett_user(int id)
        {
            t_user t_user = await db.t_user.FindAsync(id);
            if (t_user == null)
            {
                return NotFound();
            }

            return Ok(t_user);
        }

        // PUT: api/t_user/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> Putt_user(int id, t_user t_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_user.UserId)
            {
                return BadRequest();
            }

            db.Entry(t_user).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!t_userExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/t_user
        [ResponseType(typeof(t_user))]
        public async Task<IHttpActionResult> Postt_user(t_user t_user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.t_user.Add(t_user);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = t_user.UserId }, t_user);
        }

        // DELETE: api/t_user/5
        [ResponseType(typeof(t_user))]
        public async Task<IHttpActionResult> Deletet_user(int id)
        {
            t_user t_user = await db.t_user.FindAsync(id);
            if (t_user == null)
            {
                return NotFound();
            }

            db.t_user.Remove(t_user);
            await db.SaveChangesAsync();

            return Ok(t_user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool t_userExists(int id)
        {
            return db.t_user.Count(e => e.UserId == id) > 0;
        }
    }
}