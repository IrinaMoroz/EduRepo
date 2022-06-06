using System.Collections.Generic;

namespace HelloWorldFr.Cars
{
    public class CarRepo
    {
        public static IEnumerable<Car> GetCars()
        {
            return new List<Car> {
                new Car {Owner ="Mike", CarType = CarType.Sedan},
                new Car {Owner ="Emma", CarType = CarType.Hetchback},
                new Car {Owner ="Denis", CarType = CarType.Jeep},
            };
        }
    }
}
