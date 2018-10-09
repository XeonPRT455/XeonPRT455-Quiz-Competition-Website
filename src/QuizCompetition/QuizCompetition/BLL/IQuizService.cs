using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IQuizService : IBaseService<t_quiz>
    {
         t_quiz Load(int id);
    }
}
