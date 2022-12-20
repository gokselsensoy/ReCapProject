// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //CarTest();
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        var result = carManager.GetAll();
        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}






