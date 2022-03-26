using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skilldal;

        public SkillManager(ISkillDal skilldal)
        {
            _skilldal = skilldal;
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
           return _skilldal.GetList();
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
