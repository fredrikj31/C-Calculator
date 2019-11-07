using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operation = "";
            int answer;

            Console.Write("Hello Stranger" + Environment.NewLine + "Im your personal calculator.");

            Console.Write(Environment.NewLine + "Please type your first number" + Environment.NewLine);
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type now enter your operation ( x , / , +, -) " + Environment.NewLine);
            operation = Console.ReadLine();

            Console.Write("Please type your second number" + Environment.NewLine);
            num2 = Convert.ToInt32(Console.ReadLine());

            if (operation == "+")
            {
                answer = num1 + num2;
                Console.Write(num1 + " + " + num2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                answer = num1 - num2;
                Console.Write(num1 + " - " + num2 + " = " + answer);
                Console.ReadLine();
            }
            else if (operation == "x")
            {
                answer = num1 * num2;
                Console.Write(num1 + " x " + num2 + " = " + answer);
                Console.ReadLine();
            } else if (operation == "/")
            {
                answer = num1 / num2;
                Console.Write(num1 + " / " + num2 + " = " + answer);
                Console.ReadLine();
            }
        }
    }
}
