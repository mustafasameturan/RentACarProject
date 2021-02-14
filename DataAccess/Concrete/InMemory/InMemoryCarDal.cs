using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = "2010", Description = "Slow"},
                new Car{CarId = 2, BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = "2021", Description = "Very Fast"},
                new Car{CarId = 3, BrandId = 3, ColorId = 2, DailyPrice = 200000, ModelYear = "2016", Description = "Fast"},
                new Car{CarId = 4, BrandId = 4, ColorId = 3, DailyPrice = 100000, ModelYear = "2012", Description = "Slow"},
                new Car{CarId = 5, BrandId = 2, ColorId = 4, DailyPrice = 150000, ModelYear = "2014", Description = "Fast"},
                new Car{CarId = 6, BrandId = 1, ColorId = 5, DailyPrice = 250000, ModelYear = "2019", Description = "Fast and Furios"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
