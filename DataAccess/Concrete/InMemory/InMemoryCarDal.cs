using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1,BrandId=1,ColorId=1, DailyPrice =852,Description= "gnfdn",ModelYear=1985},
                new Car { Id = 2,BrandId=2,ColorId=2, DailyPrice =4615,Description= "dfbd",ModelYear=2015},
                new Car { Id = 3,BrandId=3,ColorId=3, DailyPrice =621,Description= "db",ModelYear=2023},
                new Car { Id = 4,BrandId=4,ColorId=4, DailyPrice =566,Description= "asdf",ModelYear=52},
                new Car { Id = 5,BrandId=5,ColorId=5, DailyPrice =753,Description= "sfn",ModelYear=46}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description; 
        }
    }
}
