using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            //carService.Add(new Car {BrandId = 4, ColorId = 3, ModelYear = 2024, DailyPrice = 1400, Description = "Golf" });
            foreach (var car in carService.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("----------");
            foreach (var car in carService.GetCarsByBrandId(4))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}