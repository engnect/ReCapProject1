using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /*carManager.Add(new Car
            {
                Id = 57,
                CarName = "BMW",
                BrandId = 1,
                ColorId = 3,
                DailyPrice =50,
                Description = "Leş ama iyi",
                ModelYear = 1999
            });*/

            var result = carManager.GetAllCarDetails();
            foreach (var car in result)
            {
                Console.WriteLine(car.BrandName);
            }



        }
    }
}
