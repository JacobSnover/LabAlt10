using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10Alt;

namespace Lab10Alt
{
    public class Validator
    {

        public static int InputValidator(int x)
        {
            int userInput = 0;
            string input = Console.ReadLine();
            while (true)
            {

                try
                {
                    
                    userInput = int.Parse(input);
                    if (userInput <= x - x || userInput > x)
                    {
                        Console.Write("That entry is not valid:\nPlease make another selection: ");
                        input = Console.ReadLine();
                        continue;
                    }

                }
                catch (IndexOutOfRangeException e)
                {



                }
                catch (Exception e)
                {
                    Console.Write("That entry is not valid:\nPlease make another selection: ");
                    input = Console.ReadLine();
                    continue;
                }
                return userInput;
            }
        }
        public static string Confirm()
        {

            while (true)
            {

                Console.Write("\n\tWould you like to by this vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "ok";
                }
                else if (test == "n" || test == "no")
                {
                    Continue();
                    return "NotOk";
                }

            }

        }

        public static string Continue()
        {

            while (true)
            {
                Console.Write("\n\tWould you like to purchase a vehicle? Y or N ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "\n\tExcellent! Let me show you what we have in stock.";
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