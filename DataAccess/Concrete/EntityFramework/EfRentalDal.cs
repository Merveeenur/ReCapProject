using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDBContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var result = from r in context.Rentals
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join c in context.Cars on r.CarId equals c.CarId
                             join u in context.Users on cu.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.CarId,
                                 CustomerId = cu.CustomerId,
                                 UserId = u.UserId,
                                 FirstName =u.FirstName ,
                                 LastName =u.LastName,
                                 

                             };
                return result.ToList();
            }
        }
    }
}
