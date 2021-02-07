using Business.Concrete;
using DataAccess.Concrete.EntityFrameworks;
using DataAccess.Concrete.InMemory;
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

            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        

        private static void CarTest4()
        {
            CarManager carManager4 = new CarManager(new EfCarDal());
            foreach (var car in carManager4.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void CarTest3()
        {
            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager2.GetByDailyPrice())
            {
                Console.WriteLine(car.CarId);
            }
            Console.WriteLine("*************");
        }

        private static void CarTest2()
        {
            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var car in carManager1.GetCarByColorId(3))
            {
                Console.WriteLine(car.ColorId);
            }
            Console.WriteLine("*************");
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarByBrandId(2))
            {
                Console.WriteLine(car.BrandId);
            }
            Console.WriteLine("*************");
        }
    }
}
