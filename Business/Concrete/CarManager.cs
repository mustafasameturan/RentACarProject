using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        //[SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfModelExist(car.Model));

            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedMessage);
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.UpdatedMessage);  
            }

            return new ErrorResult(Messages.ErrorMessage);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour >= 02 && DateTime.Now.Hour <= 03)
            {
                return new ErrorDataResult<List<Car>>(Messages.DeletedMessage);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.EntitiesListed);
        }

        public IDataResult<List<CarDetailDto>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == id));
        }

        public IDataResult<List<CarDetailDto>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.ColorId == id));
        }

        public IDataResult<List<CarDetailDto>> GetAllByBrandIdAndColorId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId && c.ColorId == colorId));
        }

        [CacheAspect]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id)); ;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        [TransactionScopeAspect]
        public IResult TransactionalTest(Car car)
        {
            Add(car);
            if (car.DailyPrice < 50)
            {
                throw new Exception("ERROR!");
            }

            Add(car);

            return null;
        }

        //BusinessRules

        private IResult CheckIfModelExist(string Model)
        {
            var result = _carDal.GetAll(c => c.Model == Model).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarModelAlreadyExist);
            }

            return new SuccessResult();
        }

      
    }
}
