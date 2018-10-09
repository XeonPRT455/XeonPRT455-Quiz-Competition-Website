using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    
        public class QuizInfoService : BaseService<t_QuizInfo>, IQuizInfoService
    {
            private IQuizInfoDAL QuizInfoDAL = DAL.Container.Resolve<IQuizInfoDAL>();
            public override void SetDal()
            {
                Dal = QuizInfoDAL;
            }
        }
 }

