﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TAdd(About t)
        {
           _aboutDal.Insert(t);
        }

        public List<About> TGetList()
        {
           return _aboutDal.GetList();
        }
        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            return _aboutDal.GetByID(id);
        }
        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
