using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new InMemoryCarDal());

            carService.Add(new Car { Id = 6, BrandId = 4, ColorId = 3, ModelYear = 2022, DailyPrice = 1600, Description = "Corolla" });

            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine(carService.GetById(3).Description);
        }
    }
}
