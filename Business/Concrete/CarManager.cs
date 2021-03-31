using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
        public IResult Add(Car car)
        {
            if (car.CarName.Length<2 || car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.CarNotAdded);
            }
            
            _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araba silindi");
            //Proje yapılırken parametre de silinecek

        }

        

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCarDetails(), "Bütün araba detayları getirildi.");

        }

        public IDataResult<List<Car>> GetById(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetById(c=>c.Id == Id));
        }

        

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araba güncellendi.");
        }
    }
}
