using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sytner.CarSale.API.Models;

namespace Sytner.CarSale.API.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);

    }
}
