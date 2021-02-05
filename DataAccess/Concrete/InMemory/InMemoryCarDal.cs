using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car>_cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car> {
            new Car{BrandId =1,CarId=1,ColorId=1,DailyPrice =100,Description="Manuel",ModelYear=2020},
            new Car{BrandId =1,CarId=2,ColorId=1,DailyPrice =120,Description="Otomatik",ModelYear=2020},
            new Car{BrandId =2,CarId=3,ColorId=2,DailyPrice =150,Description="Otomatik",ModelYear=2021},
            new Car{BrandId =2,CarId=4,ColorId=2,DailyPrice =200,Description="Manuel",ModelYear=2019},
            new Car{BrandId =3,CarId=5,ColorId=3,DailyPrice =180,Description="Manuel",ModelYear=2018}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColorId(int ColorId)
        {
            return _cars.Where(c =>c.ColorId==ColorId).ToList();
        }

        //public List<Car> GetById()
        //{
        //    return _cars;
        //}

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

           

        }
    }
}
