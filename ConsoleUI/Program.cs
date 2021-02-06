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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarByBrandId(2))
            {
                Console.WriteLine(car.BrandId);
            }
            Console.WriteLine("*************");

            CarManager carManager1 = new CarManager(new EfCarDal());
            foreach (var car in carManager1.GetCarByColorId(3))
            {
                Console.WriteLine(car.ColorId);
            }
            Console.WriteLine("*************");

            CarManager carManager2 = new CarManager(new EfCarDal());
            foreach (var car in carManager2.GetByDailyPrice())
            {
                Console.WriteLine(car.CarId);
            }
            Console.WriteLine("*************");

            CarManager carManager4 = new CarManager(new EfCarDal());
            foreach (var car in carManager4.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
