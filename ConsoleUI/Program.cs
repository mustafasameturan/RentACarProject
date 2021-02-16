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
            //CarTest();
            //BrandTest();
            //ColorTest();
            //PowerTest();
            //UserTest();
            CustomerTest();

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { RentalId = 13, CarId = 9, CustomerId = 5, RentalDate = DateTime.Now });

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetByDailyPrice(50,500).Data)
            //{
            //    Console.WriteLine(car.Description);
            //}

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var c in customerManager.GetAll().Data)
            {
                Console.WriteLine(c.CompanyName);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User {UserId = 12, FirstName = "Fikret", LastName = "Kabasakal", EMail = "fikretkabasakal@gmail.com" , Password = "fikret1123" });
        }

        private static void PowerTest()
        {
            PowerManager powerManager = new PowerManager(new EfPowerDal());

            foreach (var power in powerManager.GetAll().Data)
            {
                Console.WriteLine(power.PowerId + " - " + power.BrandId + " - " + power.HorsePower);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 11, BrandName = "Redbull" });
            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " - " + car.Model);
            }
        }
    }
}
