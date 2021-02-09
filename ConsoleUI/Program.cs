using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            PowerManager powerManager = new PowerManager(new EfPowerDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " - " + car.Model + " - " + car.DailyPrice );
            }
            
            //carManager.Add(new Car {BrandId =2, ColorId = 1, DailyPrice = 600000, Description = "SF1000", Id = 1, ModelYear = "2020" });

            //carManager.Delete(new Car { Id = 7});

            
        }
    }
}
