using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.CarName.Length<2 || car.DailyPrice<=0)
            {
                Console.WriteLine("İsim 2 karakterden küçük olamaz.");
            }
            else
            {
                _carDal.Add(car);
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetAllCarDetails()
        {
            return _carDal.GetAllCarDetails();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetById(c=>c.Id == Id);
        }

        

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
