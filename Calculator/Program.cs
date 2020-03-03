/*This calculator is just for 2 numbers at a time, first number operator second number. 
 * 
 * 
 */




using System;
using Calculator.Utils;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 0;
            var calc = Operator.GetInstance();

            while (input != 99)
            {
                Console.WriteLine("Choose Operator:\n1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Quit");
                input = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(input);

                //Add
                if (input == 1)
                {
                    Console.WriteLine("First Number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Sum: " + calc.Add(num1, num2) + "\n");
                }
                //Subtract
                else if (input == 2)
                {
                    Console.WriteLine("First Number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Answer: " + calc.Subtract(num1, num2) + "\n");
                }
                //Multiply
                else if (input == 3)
                {
                    Console.WriteLine("First Number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Answer: " + calc.Multiply(num1, num2) + "\n");
                }
                //Divide
                else if (input == 4)
                {
                    Console.WriteLine("First Number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Second Number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Answer: " + calc.Divide(num1, num2) + "\n");
                }
                //Quit
                else if (input == 5)
                {
                    input = 99;                    
                }
                else
                {
                    Console.WriteLine("Not an Option. Try Again!\n");
                }
            }
        }
    }
}
