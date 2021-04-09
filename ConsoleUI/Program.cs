using Business.Concrete;
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
            //ColorTest();            
            //BrandTest();
            //RentalTest();
            //CustomerTest();




        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Console.WriteLine(customerManager.Add(new Customer { CustomerId = 3, UserId=1,CompanyName="Sütaş"}).Message);          
            //Console.WriteLine(customerManager.Delete(new Customer { CustomerId = 2, UserId = 2, CompanyName = "Köfteci Yusuf" }));
            //Console.WriteLine(customerManager.Update(new Customer { CustomerId = 3, UserId = 2, CompanyName = "Köfteci Yusuf" }));
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine(customerManager.GetAll().Message);
            //    Console.WriteLine("CustomerId {0} / UserId {1} / CompanyName {2}", customer.CustomerId, customer.UserId, customer.CompanyName);
            //}
            var result = customerManager.GetCustomersById(3);
            Console.WriteLine(customerManager.GetCustomersById(1));
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Console.WriteLine(rentalManager.Add(new Rental { Id = 10, CarId = 1, CustomerId = 1, RentDate = DateTime.Now.AddDays(-5), ReturnDate = DateTime.Now.AddDays(-10) }).Message);
            //Console.WriteLine(rentalManager.Update(new Rental { Id = 4, CarId = 2, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(-6) }).Message);
            //foreach (var rental in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(rentalManager.GetAll().Message);
            //    Console.WriteLine("Rental Id {0} / Car Id {1} / Customer Id {2} / Rent Date {3} / Return Date {4}", rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
            //}

            Console.WriteLine(rentalManager.GetRentalsById(5));
        }


        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorId + " ==> " + color.ColorName);
            }

            Console.WriteLine("--- İstediğiniz Renk ---");
            Console.WriteLine(colorManager.GetById(1));

            Console.WriteLine("--- Renk Eklendi ---");
            colorManager.Add(new Color() { ColorId = 6, ColorName = "Turuncu" });

            Console.WriteLine("--- Renk Güncellendi ---");
            colorManager.Update(new Color() { ColorId = 3, ColorName = "Siyah" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine("--- Tüm Markalar ---");
            var result = brandManager.GetAll();

            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + " ==> " +  brand.BrandName);
            }

            Console.WriteLine("--- İstediğiniz Marka Araç ---");
            Console.WriteLine(brandManager.GetById(1));

            Console.WriteLine("--- Marka Eklendi ---");
            brandManager.Add(new Brand() {BrandId=6, BrandName="Dacia" });

            Console.WriteLine("--- Araç Güncellendi ---");
            brandManager.Update(new Brand() { BrandId = 5, BrandName = "Suzuki" });

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));
            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.CarId + " ==> " + car.BrandName + " ==> " + car.ColorName + " ==> " + car.DailyPrice);
            }
            
            //Console.WriteLine("---Araba Eklendi ---");
            //carManager.Add(new Car() {CarId=7, BrandId = 3, ColorId = 3, CarName = "Ferrari", DailyPrice = 100000, Description = "Lüks Araç", ModelYear = 2021 });

            //Console.WriteLine("--- Araç Güncellendi ---");
            //carManager.Update(new Car() { CarId = 6, CarName = "Red Bull" });

            //Console.WriteLine("--- Araç Silindi ---");
            //carManager.Delete(new Car() {CarId=6 });

            Console.WriteLine("--- İstediğiniz Araç ---");
            Console.WriteLine(carManager.GetCarsByBrandId(1));

        }
    }
}
