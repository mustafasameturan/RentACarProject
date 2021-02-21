using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
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

        public IResult Add(Power power)
        {
            ValidationTool.Validate(new PowerValidator(), power);

            _powerDal.Add(power);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Power power)
        {
            _powerDal.Delete(power);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<Power>> GetAll()
        {
            return new SuccessDataResult<List<Power>>(_powerDal.GetAll(),Messages.EntitiesListed);
        }

        public IResult Update(Power power)
        {
            _powerDal.Update(power);
            return new SuccessResult(Messages.UpdatedMessage);
        }
    }
}
