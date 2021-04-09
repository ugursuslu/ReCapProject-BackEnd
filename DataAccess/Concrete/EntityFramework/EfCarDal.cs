using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
    {
        public List<CarDTO> GetCarDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId
                             join color in context.Colors
                             on car.ColorId equals color.ColorId
                             select new CarDTO { CarId = car.CarId, BrandName = brand.BrandName, ColorName=color.ColorName, DailyPrice = car.DailyPrice };
                return result.ToList();
            }
        }
    }
}
