using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,ReCapProjectDatabaseContext> , IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapProjectDatabaseContext context = new ReCapProjectDatabaseContext())
            {
                var result = from rental in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join cars in context.Cars
                             on rental.CarId equals cars.CarId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId
                             join user in context.Users
                             on customer.UserId equals user.Id
                             join color in context.Colors
                             on cars.ColorId equals color.ColorId
                             join brand in context.Brands
                             on cars.BrandId equals brand.BrandId
                             select new RentalDetailDto
                             {
                                 RentalId = rental.RentalId,
                                 RentDate = rental.RentalDate,
                                 ReturnDate = rental.ReturnDate,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 CarId = cars.CarId,
                                 DailyPrice = cars.DailyPrice,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 ModelYear = cars.ModelYear,
                                 CustomerId = customer.CustomerId,
                                 Model = cars.Model,
                                 Description = cars.Description
                                 
                             };
                
                return result.ToList();


            }
        }
       
    }
}
