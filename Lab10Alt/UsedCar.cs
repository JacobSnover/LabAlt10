using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class UsedCar : Car
    {
        double Miles = 0.0;
        public UsedCar(string make, string model, int year, double price, double miles) : base(make,model,year,price)
        {
            Miles = miles;
        }

        public override string ToString()
        {
            return $"Used  |{Make}  |{Model}  |{Year}  |{Price,  8:C}   |{Miles}  |";
        }
    }
}
