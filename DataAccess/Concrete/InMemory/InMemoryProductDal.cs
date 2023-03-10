//using DataAccess.Abstract;
//using Entities.Concrete;
//using Entities.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryProductDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryProductDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{Id = 1, BrandId = 1, DailyPrice = 259000, Description = "BMW 1.4", ModelYear = "2017"},
//                new Car{Id = 2, BrandId = 2, DailyPrice = 301000, Description = "Mercedes 1.6", ModelYear = "2019"},
//                new Car{Id = 3, BrandId = 3, DailyPrice = 230000, Description = "VW 1.4", ModelYear = "2017"},
//                new Car{Id = 4, BrandId = 3, DailyPrice = 204000, Description = "VW 1.3", ModelYear = "2012"},
//                new Car{Id = 5, BrandId = 3, DailyPrice = 379000, Description = "VW 1.6", ModelYear = "2021"}
//            };

//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
//            _cars.Remove(carToDelete);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(c => c.Id == Id).ToList();
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//        }
//    }
//}
