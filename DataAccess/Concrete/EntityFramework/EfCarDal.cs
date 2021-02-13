using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands  
                             on c.BrandId equals b.Id
                             join d in context.Colors
                             on c.ColorId equals d.Id
                             select new CarDetailDto {CarName=c.CarName,BrandName= b.BrandName,ColorName=d.ColorName,DailyPrice=c.DailyPrice};

                return result.ToList();

            }
        }
    }
}
