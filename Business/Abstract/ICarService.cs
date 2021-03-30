using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IResult TransactionalTest(Car car);

        IDataResult<Car> GetById(int id);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetAllByBrandIdAndColorId(int brandId, int colorId);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        

    }
}
