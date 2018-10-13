using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            bool ynAnswer = true;  //Bool value is true which changes to false with a no to continueing answer

            /*** Run loop asking for input and calculating values until user says they do not want to continue */
            do
            {
                Console.Write("\nEnter Length: ");
                bool input = int.TryParse(Console.ReadLine(), out int length);                   
                if (input == false)
                {
                    Console.Write("Invalid response, please enter length: ");
                    input = int.TryParse(Console.ReadLine(), out length);
                }

                Console.Write("Enter Width: ");
                input = int.TryParse(Console.ReadLine(), out int width);
                if (input == false)
                {
                    Console.Write("Invalid response, please enter Width: ");
                    input = int.TryParse(Console.ReadLine(), out width);
                }

                Console.Write("Enter Height: ");
                input = int.TryParse(Console.ReadLine(), out int height);
                if (input == false)
                {
                    Console.Write("Invalid respone, please enter height: ");
                    input = int.TryParse(Console.ReadLine(), out height);
                }

                int area = length * width;
                int perimeter = (2 * length) + (2 * width);
                int volume = length * width * height;
                
                Console.WriteLine("The area is: " + area);
                Console.WriteLine("The perimeter is: " + perimeter);
                Console.WriteLine("The volume is: " + volume);

                input = false;  //bool value is false until appropriate input is entered then breaks out of loop

                while (input == false)
                {
                    Console.WriteLine("\nContinue? (y/n)");

                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "y":
                        case "Y":
                            ynAnswer = true;
                            input = true;
                            break;
                        case "n":
                        case "N":
                            ynAnswer = false;
                            input = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Response, type y for yes and n for no");
                            break;
                    }
                }   
                
            } while (ynAnswer == true);
        }
    }
}
