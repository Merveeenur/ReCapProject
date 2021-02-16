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
                var result = from u in context.Users
                             join cu in context.Customers on u.UserId equals cu.UserId
                             join r in context.Rentals on u.UserId equals r.CustomerId
                             select new RentalDetailDto
                             {
                                 FirstName=u.FirstName ,
                                 LastName =u.LastName,
                                 
                             };
                return result.ToList();
            }
        }
    }
}
