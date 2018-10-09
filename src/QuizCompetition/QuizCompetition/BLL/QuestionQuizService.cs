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
    }
}
