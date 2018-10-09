using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class ScoreInfoService: BaseService<t_ScoreInfo>,IScoreInfoService
    {
     
            private IScoreInfoDAL ScoreInfoDAL = DAL.Container.Resolve<IScoreInfoDAL>();
            public override void SetDal()
            {
                Dal = ScoreInfoDAL;
            }
    }
}
