using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Panel
{
    class Calculator
    {
        private string input1;
        private string input2;
        private int num1;
        private int num2;
        public void Add()
        {
            Console.Write("\nEnter first number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            input2 = Console.ReadLine();
            while (!Int32.TryParse(input1, out num1) || !Int32.TryParse(input2, out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0} + {1} = {2}", num1, num2, num1 + num2);
            Console.ResetColor();
        }
        public void Subtract()
        {
            Console.Write("\nEnter first number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            input2 = Console.ReadLine();
            while (!Int32.TryParse(input1, out num1) || !Int32.TryParse(input2, out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0} - {1} = {2}", num1, num2, num1 - num2);
            Console.ResetColor();
        }
        public void Multiply()
        {
            Console.Write("\nEnter first number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            input2 = Console.ReadLine();
            while (!Int32.TryParse(input1, out num1) || !Int32.TryParse(input2, out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0} * {1} = {2}", num1, num2, num1 * num2);
            Console.ResetColor();
        }
        public void Divide()
        {
            Console.Write("\nEnter first number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            input2 = Console.ReadLine();
            while (num1 == 0 || num2 == 0)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError! Divide by 0 is detected! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                    input2 = Console.ReadLine();
                if ((!Int32.TryParse(input1, out num1)) || !Int32.TryParse(input2, out num2));
            }
            while (!Int32.TryParse(input1, out num1) || !Int32.TryParse(input2, out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0} / {1} = {2}", num1, num2, num1 / num2);
            Console.ResetColor();
        }
        public void Modulo()
        {
            Console.Write("\nEnter first number: ");
            input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            input2 = Console.ReadLine();
            while (!Int32.TryParse(input1, out num1) || !Int32.TryParse(input2, out num2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value! Try again!");
                Console.ResetColor();
                Console.Write("Enter first number: ");
                input1 = Console.ReadLine();
                Console.Write("Enter second number: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: {0} % {1} = {2}", num1, num2, num1 % num2);
            Console.ResetColor();
        }
    }
}
