using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCompetition.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string NickName { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<System.DateTime> Birth { get; set; }
        public Nullable<System.DateTime> LastTimeLogOn { get; set; }
        public Nullable<double> Credits { get; set; }
    }
}