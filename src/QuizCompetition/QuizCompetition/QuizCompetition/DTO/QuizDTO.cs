using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCompetition.DTO
{
    public class QuizDTO
    {
        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public Nullable<int> Duration { get; set; }
    }
}