using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sytner.CarSale.API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
        public string Registration { get; set; }
        public int Price { get; set; }

        // TODO: Add the rest of the properties
        //public int Milage { get; set; }
        //public int EngineType { get; set; }
        //public float Mpg { get; set; }
        //public int Emmision { get; set; }
        //public int TransmisionType { get; set; }
        //public int BodyType { get; set; }
        //public int Doors { get; set; }
        //public string Description { get; set; }
        //public int InsuranceGroup { get; set; }
    }
}
