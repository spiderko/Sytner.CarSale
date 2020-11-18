using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sytner.CarSale.API.Models;
using Sytner.CarSale.API.Repositories;

namespace Sytner.CarSale.API.Controllers
{
    [Route("api/used-cars")]
    [ApiController]
    public class UsedCarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public UsedCarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // GET api/used-cars
        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
            var cars = _carRepository.GetAllCars();

            return Ok(cars);
        }

        // GET api/used-cars/{id}
        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            var car = _carRepository.GetCarById(id);

            return Ok(car);
        }
    }
}
