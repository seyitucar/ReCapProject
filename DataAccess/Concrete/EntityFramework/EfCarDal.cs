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
                var result = from ca in context.Cars
                             join br in context.Brands  
                             on ca.BrandId equals br.Id
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             select new CarDetailDto {Id=ca.Id,CarName=ca.CarName,BrandName= br.BrandName,ColorName=co.ColorName,DailyPrice=ca.DailyPrice,Description=ca.Description,ModelYear=ca.ModelYear};

                return result.ToList();

            }
        }
    }
}
