using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class QuestionQuizService : BaseService<t_Question_Quiz>, IQuestionQuizService
    {
        private IQuestionQuizDAL QuestionQuizDAL = DAL.Container.Resolve<IQuestionQuizDAL>();
        public override void SetDal()
        {
            Dal = QuestionQuizDAL;
        }

        public List<int> getQuestionsId(int id)
        {
            List<t_Question_Quiz> lqq = GetModels(p => p.QuizId == id).ToList();
            List<int> lqqq = new List<int>();

            foreach (t_Question_Quiz tqq in lqq)
            {
                lqqq.Add(tqq.QuestionId);
            }
            return lqqq;
        }
    }
}
