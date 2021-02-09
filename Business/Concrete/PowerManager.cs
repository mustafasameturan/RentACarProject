using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PowerManager : IPowerService
    {
        IPowerDal _powerDal;

        public PowerManager(IPowerDal powerDal)
        {
            _powerDal = powerDal;
        }

        public void Add(Power power)
        {
            _powerDal.Add(power);
        }

        public void Delete(Power power)
        {
            _powerDal.Delete(power);
        }

        public List<Power> GetAll()
        {
            return _powerDal.GetAll();
        }

        public List<Power> GetAllByBrandId(int id)
        {
            return _powerDal.GetAll(p => p.BrandId == id);
        }

        public void Update(Power power)
        {
            _powerDal.Update(power);
        }
    }
}
