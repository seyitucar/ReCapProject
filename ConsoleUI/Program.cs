using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("-------------Marka Id bazında araba listesi----------------");

            foreach (var car in carManager.GetCarsByBrandId(6))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------Renk Id bazında araba listesi----------------");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------Marka ekleme kodu / başarılı----------------");

            brandManager.Add(new Brand { BrandName="Dacia"});

            Console.WriteLine("-------------Marka ekleme kodu / başarısız----------------");

            brandManager.Add(new Brand {  BrandName= "S"});

            Console.WriteLine("-------------Araba ekleme kodu / başarılı----------------");

            carManager.Add(new Car {ColorId=3,ModelYear=1985,Description="Cassical car",BrandId=6,DailyPrice = 485 });

            Console.WriteLine("-------------Araba ekleme kodu / başarısız----------------");

            carManager.Add(new Car { DailyPrice = 0 });
        }
    }
}
