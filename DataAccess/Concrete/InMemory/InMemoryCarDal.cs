using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal
    {
        //List<Car> cars;
        //public InMemoryCarDal()
        //{
        //    cars = new List<Car> { new Car { Id=1, CarName= "Volvo",BrandId=1, ColorId=1, DailyPrice= 100, 
        //        Description="Hoş araba", ModelYear= 2010}, 
        //        new Car { Id=2 ,CarName= "Seat",BrandId=2, ColorId=2, DailyPrice = 250, 
        //            Description= "Müko araba", ModelYear = 2015} };
        //}
        //public void Add(Car car)
        //{
        //    cars.Add(car);
        //}

        
        //public void Delete(Car car)
        //{
        //    Car carToDelete = cars.SingleOrDefault(c=>c.Id == car.Id);
        //    cars.Remove(carToDelete);
        //}

        //public List<Car> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<CarDetailDto> GetAllCarDetails()
        //{
        //    throw new NotImplementedException();
        //}

        //public Car GetById(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToUpdate.ModelYear = car.ModelYear;

        //}

        //Car IEntityRepository<Car>.GetById(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
