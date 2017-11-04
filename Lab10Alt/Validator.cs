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
    }
}