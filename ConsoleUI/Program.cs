using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //KiralamaSonlandirma(rentalManager);

            //KiralamaEkleme(rentalManager);

            //MusteriEkleme(customerManager);

            //ArabalariListele(carManager);

            //ArabaSilme(carManager);

            //ArabaEkle(carManager);

            //ArabaGuncelle(carManager);

            //MarkaEkleBasarili(brandManager);

            //MarkaEkleBasarisiz(brandManager);

            //MarkaGuncellemeBasarili(brandManager);

            //MarkaGuncellemeBasarisiz(brandManager);

            //MarkaSilme(brandManager);

            //RenkEkleme(colorManager);

            //RenkSilme(colorManager);

            //RenkGuncelleme(colorManager);

        }

        private static void KiralamaSonlandirma(RentalManager rentalManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("****  Kiralama Sonlandirma ***");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result14 = rentalManager.EndRental(3);

            if (result14.Success)
            {
                Console.WriteLine(result14.Message);
                foreach (var rental in rentalManager.GetRentalDetails().Data)
                {
                    Console.WriteLine("Kiralama Tarihi : "+rental.RentDate + " " +"Kira Bitiş Tarihi "+rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result14.Message);
            }
        }

        private static void KiralamaEkleme(RentalManager rentalManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("*****  Kiralama Ekleme    ****");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result13 = rentalManager.Add(new Rental { CarId = 3, CustomerId = 6, RentDate = DateTime.Now.Date });

            if (result13.Success)
            {
                Console.WriteLine(result13.Message);
                foreach (var rental in rentalManager.GetRentalDetails().Data)
                {
                    Console.WriteLine(rental.RentDate + " " + rental.CarName);
                }
            }
            else
            {
                Console.WriteLine(result13.Message);
            }
        }


        private static void MusteriEkleme(CustomerManager customerManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("*****   Müşteri Ekleme    ****");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result12 = customerManager.Add(new Customer { UserId = 5, CompanyName = "Best" });

            if (result12.Success)
            {
                Console.WriteLine(result12.Message);
                foreach (var customer in customerManager.GetCustomerDetails().Data)
                {
                    Console.WriteLine(customer.FirstName);
                }
            }
            else
            {
                Console.WriteLine(result12.Message);
            }
        }

        private static void RenkGuncelleme(ColorManager colorManager)
        {

            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("*****   Renke Guncelleme  ****");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result12 = colorManager.Update(new Color { Id = 1003, ColorName = "Dark Blue" });

            if (result12.Success)
            {
                Console.WriteLine(result12.Message);
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result12.Message);
            }

        }
        private static void RenkSilme(ColorManager colorManager)
        {

            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("*****    Renke Silme   ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result11 = colorManager.Delete(new Color { Id=1004, ColorName = "Blue" });

            if (result11.Success)
            {
                Console.WriteLine(result11.Message);
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result11.Message);
            }

        }
        private static void RenkEkleme(ColorManager colorManager)
        {

            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("*****    Renke Ekleme   ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");


            var result10 = colorManager.Add(new Color { ColorName = "Blue" });

            if (result10.Success)
            {
                Console.WriteLine(result10.Message);
                foreach (var color in colorManager.GetAll().Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result10.Message);
            }

        }

        private static void ArabaGuncelle(CarManager carManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("***** Araba  Guncelle   ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result9 = carManager.Update(new Car {Id=8042, BrandId = 6, CarName = "2008", ColorId = 2, DailyPrice = 110, Description = "2.0 manual transmission", ModelYear = 2017 });

            if (result9.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result9.Message);
            }
        }
        private static void ArabaEkle(CarManager carManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("***** Araba  Ekleme     ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result8 = carManager.Add(new Car {BrandId = 6, CarName = "2008", ColorId = 2, DailyPrice = 120, Description = "2.0 manual transmission", ModelYear = 2017 });

            if (result8.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result8.Message);
            }
        }

        private static void ArabaSilme(CarManager carManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("***** Arabaa Silme      ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result7 = carManager.Delete(new Car { Id = 8, BrandId = 5, CarName = "S60", ColorId = 4, DailyPrice = 80, Description = "Volvo 1.8d manual transmission", ModelYear = 2010 });

            if (result7.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result7.Message);
            }
        }

        private static void MarkaSilme(BrandManager brandManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("********************************");
            Console.WriteLine("*********  Marka Silme  ********");
            Console.WriteLine("********************************");
            Console.WriteLine("                              ");

            var result6 = brandManager.Delete(new Brand { Id = 9012, BrandName = "Bugatti" });

            if (result6.Success)
            {

                Console.WriteLine(result6.Message);
                Console.WriteLine("                              ");

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result6.Message);
                Console.WriteLine("                              ");
            }
        }

        private static void MarkaGuncellemeBasarisiz(BrandManager brandManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("********************************");
            Console.WriteLine("* Marka Güncelleme / Başarısız *");
            Console.WriteLine("********************************");
            Console.WriteLine("                              ");

            var result5 = brandManager.Update(new Brand { Id = 9016, BrandName = "A" });

            if (result5.Success)
            {

                Console.WriteLine(result5.Message);
                Console.WriteLine("                              ");

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result5.Message);
                Console.WriteLine("                              ");
            }
        }

        private static void MarkaGuncellemeBasarili(BrandManager brandManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("********************************");
            Console.WriteLine("* Marka Güncelleme / Başarılı **");
            Console.WriteLine("********************************");
            Console.WriteLine("                              ");

            var result4 = brandManager.Update(new Brand { Id = 9016, BrandName = "Tofaş" });

            if (result4.Success)
            {

                Console.WriteLine(result4.Message);
                Console.WriteLine("                              ");

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result4.Message);
                Console.WriteLine("                              ");
            }
        }

        private static void MarkaEkleBasarili(BrandManager brandManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("** Marka Ekle / Başarılı   ***");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result3 = brandManager.Add(new Brand { BrandName = "Tata" });

            if (result3.Success)
            {

                Console.WriteLine(result3.Message);
                Console.WriteLine("                              ");

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result3.Message);
                Console.WriteLine("                              ");
            }
        }

        private static void MarkaEkleBasarisiz(BrandManager brandManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("** Marka Ekle / Başarısız  ***");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result2 = brandManager.Add(new Brand { BrandName = "L" });

            if (result2.Success)
            {

                Console.WriteLine(result2.Message);
                Console.WriteLine("                              ");

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
                Console.WriteLine("                              ");
            }
        }

        private static void ArabalariListele(CarManager carManager)
        {
            Console.WriteLine("                              ");
            Console.WriteLine("******************************");
            Console.WriteLine("***** Arabaları Listele ******");
            Console.WriteLine("******************************");
            Console.WriteLine("                              ");

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}


