using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IQuestionService : IBaseService<t_question>
    {
        List<t_question> GetListById(List<int> idl);
    }
}
