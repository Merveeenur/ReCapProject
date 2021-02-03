using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{ 
    //car ile ilgili veri tabanında yapacağım işlemler burada olur
   public interface ICarDal
    {
        List<Car>GetAll();
        List<Car> GetAllByColorId(int ColorId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
