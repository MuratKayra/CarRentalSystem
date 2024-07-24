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
            //CarTest();
            //BrandTest();
            //ColorTest();
        }

        private static void ColorTest()
        {
            IColorService colorService = new ColorManager(new EfColorDal());
            foreach (var color in colorService.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            IBrandService brandService = new BrandManager(new EfBrandDal());
            foreach (var brand in brandService.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
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

            Console.WriteLine("----------");

            foreach (var car in carService.GetCarDetails())
            {
                Console.WriteLine("{0} {1} {2} {3}", car.BrandName, car.CarName, car.ColorName, car.DailyPrice);
            }
        }
    }
}