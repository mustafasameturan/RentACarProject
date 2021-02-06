using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }

            Console.WriteLine("------------------------------------");

            foreach (var car in carManager.GetAllByBrandId(2))
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }

            Console.WriteLine("------------------------------------");

            foreach (var car in carManager.GetAllByColorId(4))
            {
                Console.WriteLine(car.Id + " - " + car.Description);
            }
        }
    }
}
