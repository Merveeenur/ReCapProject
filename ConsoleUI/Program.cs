using Business.Concrete;
using DataAccess.Concrete.EntityFrameworks;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //CarTest2();

            //CarTest3();

            // CarTest4();

            //ColorTest();

            //BrandTest();

            CarTest5();

            //CarAddTest();

        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarId = 7, BrandId = 3, CarName = "i320", ColorId = 2, DailyPrice = 134, Description = "Manuel", ModelYear = 2010 });
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car);
            }
        }

        private static void CarTest5()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "==>" + car.BrandName + "==>" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest4()
        {
            CarManager carManager4 = new CarManager(new EfCarDal());
            foreach (var car in carManager4.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }   
        }

        private static void CarTest3()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager2.GetByDailyPrice().Data)
            {
                Console.WriteLine(car.CarId);
            }
            Console.WriteLine("*************");
        }

        private static void CarTest2()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var car in carManager1.GetCarByColorId(3).Data)
            {
                Console.WriteLine(car.ColorId);
            }
            Console.WriteLine("*************");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarByBrandId(2).Data)
            {
                Console.WriteLine(car.BrandId);
            }
            Console.WriteLine("*************");
        }
    }
}
