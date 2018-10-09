using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IQuestionQuizService : IBaseService<t_Question_Quiz>
    {
        List<int> getQuestionsId(int id);
    }
}
