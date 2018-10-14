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

            // James - no shame in typing out the full name for a variable, in C#,
            // it's common convention to write out the entire variable name, it makes your code
            // much more readable at the end of the day.  another common convention is to name 
            // booleans based on an assumed truth.  for example
            //
            // bool isAnswer
            // bool isRunning
            // bool isYes
            //
            // Also because this boolean is actually used so far away from the actual while loop,
            // at first glance would have to reference a bit to this boolean.  you could always
            // just put true in the while loop and break if you do not want to continue the loop.
            bool ynAnswer = true;  //Bool value is true which changes to false with a no to continueing answer

            /*** Run loop asking for input and calculating values until user says they do not want to continue */
            // James - usually you won't see multi line comments, it was made popular in c++ and now 
            // devs just use single line comments, like what I'm doing, not sure why but it's pretty typically
            // like this.
            do
            {
                Console.Write("\nEnter Length: ");
                bool input = int.TryParse(Console.ReadLine(), out int length);   // James - is this the right type?                
                if (input == false)
                {
                    // James - if the user enters an invalid entry again, then
                    // the computer will continue with an invalid entry, validation
                    // was not part of the assignment so it's fine for right now
                    // but think of a way to solve this problem.
                    Console.Write("Invalid response, please enter length: ");
                    input = int.TryParse(Console.ReadLine(), out length);
                }

                Console.Write("Enter Width: ");
                input = int.TryParse(Console.ReadLine(), out int width);
                if (input == false)
                {
                    // James - Refer to line 45
                    Console.Write("Invalid response, please enter Width: ");
                    input = int.TryParse(Console.ReadLine(), out width);
                }

                Console.Write("Enter Height: ");
                input = int.TryParse(Console.ReadLine(), out int height);
                if (input == false)
                {
                    // James - Refer to line 45
                    Console.Write("Invalid respone, please enter height: ");
                    input = int.TryParse(Console.ReadLine(), out height);
                }

                // James - I'll give you a sneak peek to a common gotcha for new developers.
                // because integers are value types, they have default values.  for pretty much all
                // integral and float types, the default value is 0, for bool it's false. 
                // however, if you are dealing with a reference type, the default value is "null",
                // and I'll let you stumble on that, because every dev does.
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
                        // James - You can use an answer.Equals("y".Equals("y", StringComparison.OrdinalIgnoreCase) )
                        // which reduces your cases by 2, Also it's usually better to use 
                        // string.Equals(), as it was created to handle strings.
                        case "y":
                        case "Y":
                            ynAnswer = true;
                            input = true;
                            break;
                        // James - refer to line 90
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
                // James - refer to line 29
            } while (ynAnswer == true);
        }

        // James - Overall good job! the validation can use some work but you experimented heavily with
        // while loops which wich is good. review the type you were using and this will be good to go.
    }
}
