using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.Abstract
{
   public interface ICarDal
    {

        List<Car> GetAll();
        List<Car> GetByID();
        public void GetAll(Car car);
        public void Add(Car car);
        public void Update(Car Car);
        public void Delete(Car car);

    }
}
