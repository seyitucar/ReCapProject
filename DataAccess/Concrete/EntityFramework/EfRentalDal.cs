using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cu in context.Customers
                             on re.CustomerId equals cu.Id
                             select new RentalDetailDto { Id=re.Id,BrandId=ca.BrandId,CarId=ca.Id,CompanName=cu.CompanyName,CustomerId=re.CustomerId,DailyPrice=ca.DailyPrice,RentDate=re.RentDate,ReturnDate=re.ReturnDate,UserId=cu.UserId};

                return result.ToList();
            }
        } 
    }
}
