using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionService : BaseService<t_question>, IQuestionService
    {
        private IQuestionDAL QuestionDAL = DAL.Container.Resolve<IQuestionDAL>();
        public override void SetDal()
        {
            Dal = QuestionDAL;
        }
    }
}
