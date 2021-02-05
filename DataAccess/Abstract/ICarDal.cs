using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{ 
    //car ile ilgili veri tabanında yapacağım işlemler burada olur
   public interface ICarDal :IEntityRepository<Car>
    {
        
    }
}
