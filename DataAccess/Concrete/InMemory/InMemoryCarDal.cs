using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    //{
    //    List<Brand> _brand;
    //    List<Car> _car;
    //    List<Color> _color;

    //    public InMemoryCarDal()
    //    {
    //        _car = new List<Car> { 
    //            new Car { CarId = 1, BrandId = 1, ColorId= 1, DailyPrice=10000, ModelYear= 2021, Description="İlk araba"},
    //            new Car { CarId = 2, BrandId = 1, ColorId= 1, DailyPrice=20000, ModelYear= 2020, Description="İkinci araba"},
    //            new Car { CarId = 3, BrandId = 2, ColorId= 3, DailyPrice=30000, ModelYear= 2019, Description="Üçüncü araba"},
    //            new Car { CarId = 4, BrandId = 2, ColorId= 3, DailyPrice=40000, ModelYear= 2018, Description="Dördüncü araba"},
    //            new Car { CarId = 5, BrandId = 3, ColorId= 4, DailyPrice=50000, ModelYear= 2017, Description="Beşinci araba"}
    //        };
    //        _brand = new List<Brand>
    //        {
    //          new Brand {BrandId = 1, BrandName = "Mercedes"},
    //          new Brand {BrandId = 2, BrandName = "Audi"},
    //          new Brand {BrandId = 3, BrandName = "BMW"}
    //        };

    //        _color = new List<Color>
    //        {
    //          new Color { ColorId= 1, ColorName = "Kırmızı"},
    //          new Color {ColorId = 2, ColorName = "Mavi"},
    //          new Color {ColorId = 3, ColorName = "Turuncu"},
    //          new Color {ColorId = 4, ColorName = "Yeşil"}
    //        };
    //    }

        

    //    public void Add(Car car)
    //    {
    //        _car.Add(car);
    //    }

    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = _car.SingleOrDefault(p => p.CarId == car.CarId);
    //        _car.Remove(carToDelete);
    //    }

    //    public List<CarDTO> GetAll()
    //    {
    //        var result = from car in _car join brand in _brand on car.BrandId equals brand.BrandId join color in _color on car.ColorId equals color.ColorId   
                              
    //                select new CarDTO
    //                {
    //                    CarId = car.CarId,                            
    //                    BrandName = brand.BrandName,
    //                    ColorName = color.ColorName,
    //                    DailyPrice = car.DailyPrice,
    //                    ModelYear = car.ModelYear,
    //                    Description = car.Description

    //                }; 

    //        return result.ToList();
    //    }

    //    public List<Car> GetByBrandId(int brandId)
    //    {
    //        return _car.Where(p => p.BrandId == brandId).ToList();
    //    }

    //    public List<Car> GetByCardId(int CarId)
    //    {
    //        return _car.Where(p => p.CarId == CarId).ToList();
    //    }

    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
    //        carToUpdate.CarId = car.CarId;
    //        carToUpdate.BrandId = car.BrandId;
    //        carToUpdate.ColorId = car.ColorId;
    //        carToUpdate.DailyPrice = car.DailyPrice;
    //        carToUpdate.ModelYear = car.ModelYear;
    //        carToUpdate.Description = car.Description;
    //    }
    //}
}
