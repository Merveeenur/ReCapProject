using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car); 
            return new Result(true, "araba silindi");

        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==17)
            {
                return new ErrorResult();
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),true,"arabalar listelendi");
        }

        public IDataResult<List<Car>> GetByDailyPrice()
        {
            return _carDal.GetAll(c => c.DailyPrice>=0);
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c => c.CarId == carId);
        }

        public IDataResult<List<Car>> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public IDataResult<List<Car>> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c =>c.ColorId == id);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, "araba güncellendi");
        }
    }
}
