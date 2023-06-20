using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC
{
    public class Car_Info
    {
        private string name, brand;
        private int mileage, price;

        public Car_Info(string name, string brand , int mileage, int price=45000 )
        {
                this.name = name;
            this.brand = brand;
            this.mileage = mileage;
            this.price = price;
        }
        public string PrintCar_Info() 
        {
            return($"Car name is {name} /  brand is {brand} / mileage is {mileage} / price is {price}");
        }
    }
     
	}
	
	

