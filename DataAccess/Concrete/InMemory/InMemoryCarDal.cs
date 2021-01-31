using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=1, DailyPrice=50, Description="New",ModelYear = 2020},
                new Car{Id=2, BrandId=2,ColorId=3, DailyPrice=70, Description="Comfort",ModelYear = 2017},
                new Car{Id=3, BrandId=2,ColorId=4, DailyPrice=70, Description="Daily",ModelYear = 2010},
                new Car{Id=4, BrandId=3,ColorId=2, DailyPrice=100, Description="Luxury",ModelYear = 2021}
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(int Id)
        {
            _cars.Find(p => p.Id == Id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=> p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

    }
}
