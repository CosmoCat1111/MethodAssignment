using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
                mathOptionalParameter math = new mathOptionalParameter();

                // user input two numbers
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number (optional): ");
                string input = Console.ReadLine();

                int num2;
                // Check if the input is empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    // If empty, uset value 0
                    num2 = 0;
                }
                else
                {
                    // If not empty, parse the input to integer
                    num2 = int.Parse(input);
                }

                // Call the method with the user input
                int result = math.MathOp(num1, num2);

                Console.WriteLine("Result of the operation: " + result);
                Console.ReadLine();
            }
        }

    }
