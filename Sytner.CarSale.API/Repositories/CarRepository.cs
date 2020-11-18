using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sytner.CarSale.API.Models;

namespace Sytner.CarSale.API.Repositories
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car> 
            { 
                new Car{ Id = 1, Make = "Ford", Model = "Fiesta", Registration = "THE1", YearOfManufacture = 2020, Price=18000 },
                new Car{ Id = 2, Make = "Fiat", Model = "500", Registration = "THE2", YearOfManufacture = 2019, Price=12000 },
                new Car{ Id = 3, Make = "BMW", Model = "i8", Registration = "THE3", YearOfManufacture = 2018, Price=65000 },
            };

            return cars;
        }

        public Car GetCarById(int id)
        {
            return new Car { Id = 1, Make = "Ford", Model = "Fiesta", Registration = "THE1", Year = 2020, Price = 18000 };
        }
    }
}
