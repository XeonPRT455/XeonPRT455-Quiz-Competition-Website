using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCompetition.DTO
{
    public class QuestionDTO
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
    }
}