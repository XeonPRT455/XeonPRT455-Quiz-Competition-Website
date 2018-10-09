using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuizService : BaseService<t_quiz>, IQuizService
    {
        private IQuizDAL QuizDAL = DAL.Container.Resolve<IQuizDAL>();
        public override void SetDal()
        {
            Dal = QuizDAL;
        }

        public t_quiz Load(int id)
        {
            return GetModels(p => p.QuizId == id).FirstOrDefault();
        }

    }
}
