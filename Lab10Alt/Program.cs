using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Alt
{
    class Program
    {


        static void Main(string[] args)
        {
            int userInput = 0;

            ArrayList Cars = new ArrayList();
            ArrayList Receipt = new ArrayList();

            Cars.Add(new Car("Pontiac  ", "Aztec  ", 1999, 21_000));
            Cars.Add(new Car("Chevrolet", "Camaro ", 2012, 35_000));
            Cars.Add(new Car("BMW      ", "M3     ", 2015, 85_000));
            Cars.Add(new UsedCar("VW       ", "Bus    ", 1965, 2_000, 189_000));
            Cars.Add(new UsedCar("Pontiac  ", "Vibe   ", 2003, 1_500, 189_000));
            Cars.Add(new UsedCar("Ford     ", "Mustang", 1989, 3_500, 120_000));
            
            Console.WriteLine(Validator.Continue());
            while (true)
            {
                Header();
                int c = 0;
                foreach (Car car in Cars)
                {
                    c++;

                    Console.WriteLine($"|>{c}. |" + car);
                    Console.WriteLine("|==============================================================|");

                }
                
                Console.Write("Enter the number for the vehicle that you would like to purchase: ");

                userInput = Validator.InputValidator(Cars.Count) - 1;
                Console.WriteLine("\n\t\t\tYou have selected");
                Header();
                Console.WriteLine($"<<|>>|{Cars[userInput]}\n");


                string confirm = Validator.Confirm();
                if (confirm == "NotOk")
                {
                    continue;
                }
                
                Receipt.Insert(0, Cars[userInput]);
                Cars.RemoveAt(userInput);
                
                Console.WriteLine("\n\t\tYour current purchases are.\n");
                Header();
                int x = 0;
                foreach (Object buys in Receipt)
                {
                    x++;
                    
                    Console.WriteLine($"|>{x}. |" + buys);
                }
                if (Cars.Count <= 0)
                {
                    Console.WriteLine("\n\t   There is no more vehicles in stock. ");
                    Console.WriteLine("\n\t\tYour current purchases are.\n");
                    Header();
                    int d = 0;
                    foreach (Object buys in Receipt)
                    {
                        d++;

                        Console.WriteLine($"|>{d}. |" + buys);
                    }
                    Console.WriteLine($"\n\t\t\tBye! ");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
                Console.WriteLine(Validator.Continue());
                
    }

        }

        private static void Header()
        {
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("|Condition  |Make       |Model    |Year  |Price       |Miles   |");
            Console.WriteLine("|==============================================================|");
        }
    }
}
