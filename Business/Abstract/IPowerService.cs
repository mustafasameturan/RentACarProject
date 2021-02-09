using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPowerService 
    {
        void Add(Power power);
        void Delete(Power power);
        void Update(Power power);
        List<Power> GetAllByBrandId(int id);
        List<Power> GetAll();
    }
}
