using System;

namespace Login_Panel
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; // Used to TryParse
            string login;
            string password;
            int select; // Selecting between calculator and notepad
            int choice; // Selecting options in the calculator
            Calculator calculator = new Calculator();
            Notepad notepad = new Notepad();

            Console.WriteLine("Welcome to the login panel!");
            Console.Write("Login: ");
            login = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            while (login != "Admin" || password != "***")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIncorrect login or password!");
                Console.ResetColor();
                Console.Write("Login: ");
                login = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nHello Admin!");
            Console.ResetColor();
            Console.WriteLine("What application do you want to open?");
            Console.WriteLine("1.Calculator\n2.Notepad\n");
            input = Console.ReadLine();
            if (!Int32.TryParse(input, out select));

            while (select != 1 && select != 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Value!");
                Console.ResetColor();
                Console.WriteLine("What application do you want to open?");
                Console.WriteLine("1.Calculator\n2.Notepad\n");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out select));
            }

            if (select == 1)
            {
                Console.WriteLine("\nOPENING THE CALCULATOR APP...\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Modulo\n");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out choice));
                while (choice < 1 || choice > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIncorrect login or password!");
                    Console.ResetColor();
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Modulo\n");
                    input = Console.ReadLine();
                    if (!Int32.TryParse(input, out choice));
                }

                switch (choice)
                {
                    case 1:
                        calculator.Add();
                        break;
                    case 2:
                        calculator.Subtract();
                        break;
                    case 3:
                        calculator.Multiply();
                        break;
                    case 4:
                        calculator.Divide();
                        break;
                    case 5:
                        calculator.Modulo();
                        break;
                }
            }

            else if (select == 2)
            {
                notepad.Write();
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nTask completed!\nLogging out");
            Console.ResetColor();
        }
    }
}