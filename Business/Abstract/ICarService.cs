using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public  interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        List<Car> GetCarByColorId(int id);
        List<Car> GetCarByBrandId(int id);
        List<Car> GetByDailyPrice();
        List<CarDetailDto> GetCarDetails();
    }

}
