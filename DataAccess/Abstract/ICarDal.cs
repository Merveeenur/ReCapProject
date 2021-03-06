﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{ 
    //car ile ilgili veri tabanında yapacağım işlemler burada olur
   public interface ICarDal :IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
