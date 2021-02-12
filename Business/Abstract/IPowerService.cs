using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPowerService 
    {
        IResult Add(Power power);
        IResult Delete(Power power);
        IResult Update(Power power);
        IDataResult<List<Power>> GetAll();
    }
}
