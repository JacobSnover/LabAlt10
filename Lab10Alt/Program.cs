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

            Cars.Add(new Car("Pontiac  ", "Aztec  ", 1999, 21_000));
            Cars.Add(new Car("Chevrolet", "Camaro ", 2012, 35_000));
            Cars.Add(new Car("BMW      ", "M3     ", 2015, 85_000));
            Cars.Add(new UsedCar("VW       ", "Bus    ", 1965, 2_000, 189_000));
            Cars.Add(new UsedCar("Pontiac  ", "Vibe   ", 2003, 1_500, 189_000));
            Cars.Add(new UsedCar("Ford     ", "Mustang", 1989, 3_500, 120_000));
            Console.WriteLine(Continue());
            while (true)
            {
                Console.WriteLine("________________________________________________________________");
                Console.WriteLine("|Condition   Make        Model     Year   Price        Miles   |");
                int c = 0;
                foreach (Car car in Cars)
                {
                    c++;

                    Console.WriteLine($"|>{c}. |" + car);
                    Console.WriteLine("|==============================================================|");

                }
                Console.Write("Enter the number for the vehicle that you would like to purchase: ");

                userInput = Validator.InputValidator(Cars.Count) - 1;
                Console.WriteLine($"\n\t\tYou have selected\n<<|>>|{Cars[userInput]}\n");
                string x = "ok";
                Console.WriteLine(Confirm(x));
                if (x != "ok")
                {
                    continue;
                }
                Console.WriteLine($"\t\tYou have purchased\n<<|>>|{Cars[userInput]}\n");
                Cars.RemoveAt(userInput);
                Console.WriteLine(Continue());

            }

        }
        public static string Confirm(string x)
        {

            while (true)
            {

                Console.Write("Would you like to by this vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "\t\t   Thank you!!";
                }
                else if (test == "n" || test == "no")
                {
                    Continue();
                    return "ok";
                }

            }

        }
        public static string Continue()
        {

            while (true)
            {
                Console.Write("Would you like to purchase a vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "ok";
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine($"Bye! ");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }
    }
}
