using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Car
    {
        private String make;
        private String model;
        private int year = 0;
        private double price = 0.0;

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"New   |{make}  |{model}  |{year}  |{price,  8:C}  |0       |";
        }
    }
}
