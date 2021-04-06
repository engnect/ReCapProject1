using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarDbContext>, ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }
    }
}
