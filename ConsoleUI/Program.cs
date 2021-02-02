using Bussiness.Concrete;
using ClassLibrary.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager (new InMemory());
            foreach (var car in carManager.GetAll())
            {

                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.ProductDescription);
            }



        }
    }
}
