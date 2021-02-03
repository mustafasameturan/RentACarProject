using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100000, ModelYear = "2010", Description = "Slow"},
                new Car{Id = 2, BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = "2021", Description = "Very Fast"},
                new Car{Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 200000, ModelYear = "2016", Description = "Fast"},
                new Car{Id = 4, BrandId = 4, ColorId = 3, DailyPrice = 100000, ModelYear = "2012", Description = "Slow"},
                new Car{Id = 5, BrandId = 2, ColorId = 4, DailyPrice = 150000, ModelYear = "2014", Description = "Fast"},
                new Car{Id = 6, BrandId = 1, ColorId = 5, DailyPrice = 250000, ModelYear = "2019", Description = "Fast and Furios"}

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

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
