

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ProductTest();

//BrandManager brandManager = new BrandManager(new EfBrandDal());
//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.BrandName);
//}

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.Id + "/" + car.BrandName);
}

static void ProductTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine(car.BrandId);
    }
}
