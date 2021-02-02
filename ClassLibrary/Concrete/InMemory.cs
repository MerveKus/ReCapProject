using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Concrete
{
    public class InMemory : ICarDal
    {
        List<Car> _cars;
        public InMemory()
            {

            _cars = new List<Car> {

            new Car {Id=1, BrandId=666, ColorId=1, ModelYear=1975, DailyPrice=110000, ProductDescription="manuel vites, otomatiğe çevrilebilir. Benzinli" },
            new Car {Id=2, BrandId=667, ColorId=2, ModelYear=2000, DailyPrice=95000, ProductDescription="manuel vites, otomatiğe çevrilebilir. Dizel" },
            new Car  {Id=3, BrandId=668, ColorId=3, ModelYear=2010, DailyPrice=120000, ProductDescription="otomatik vites, Benzinli" },
            };
            }
      
        public void Add(Car car)
        {
            _cars.Add(car);
           
        }

        public void Delete(Car car)
        {
           Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            // p linq te tek tek dolaşmak için verilen allias isim.
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetAll(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();

        }

        public List<Car> GetByID()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
