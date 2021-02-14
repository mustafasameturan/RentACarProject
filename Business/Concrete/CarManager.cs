using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.AddedMessage);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedMessage);
        }
        public IResult Update(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.UpdatedMessage);  
            }

            return new ErrorResult(Messages.ErrorMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour >= 02 && DateTime.Now.Hour <= 03)
            {
                return new ErrorDataResult<List<Car>>(Messages.DeletedMessage);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.EntitiesListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id)); ;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

    }
}
