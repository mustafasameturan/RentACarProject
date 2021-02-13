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
            //CustomerTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { CustomerId = 11, UserId = 11 });
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
                Console.WriteLine(power.Id + " - " + power.BrandId + " - " + power.HorsePower);
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

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
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
