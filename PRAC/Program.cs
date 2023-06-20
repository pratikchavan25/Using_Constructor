using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using optional parameter

            Car_Info car = new Car_Info("Q7","audi",25);
            Console.WriteLine(car.PrintCar_Info());

            // using explicit value - override the value (i.e default price will change )

            Car_Info car1 = new Car_Info("passat","volksvagon",60,100000);
            Console.WriteLine(car1.PrintCar_Info());

            // Using NAMED ARGUEMENTS 

            Car_Info car2 = new Car_Info(name: "fortuner", brand: "toyota", mileage: 20, price: 3200000);
            Console.WriteLine(car2.PrintCar_Info());
        }

    }
}
