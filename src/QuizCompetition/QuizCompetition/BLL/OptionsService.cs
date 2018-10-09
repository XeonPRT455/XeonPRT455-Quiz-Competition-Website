using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OptionsService : BaseService<t_options>, IOptionsService
    {
        private IOptionsDAL OptionsDAL = DAL.Container.Resolve<IOptionsDAL>();
        public override void SetDal()
        {
            Dal = OptionsDAL;
        }

        public List<t_options> GetOptionsList(int id)
        {
            List<t_options> lo = GetModels(p => p.QuestionId == id).ToList();
            return lo;
        }
    }
}
