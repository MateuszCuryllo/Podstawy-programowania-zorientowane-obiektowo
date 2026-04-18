using System;

class Program
{
    static void Main()
    {
        Console.Write("Welcome in Calculator\n \nPlis give me first number: ");
        float number_1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Chose what you want to do:\n - subtraction\n + addition\n * multiplication\n / division");
        string sign = Console.ReadLine();

        Console.WriteLine("Plis give me a second number");
        float number_2 = float.Parse(Console.ReadLine());
        float result = 0;
        bool succes = true;

        if (sign == "-" || sign == "subtraction")
        {
            result = number_1 - number_2;
        }
        else if (sign == "+" || sign == "addition")
        {
            result = number_1 + number_2;
        }
        else if (sign == "*" || sign == "multiplication")
        {
            result = number_1 * number_2;
        }
        else if (sign == "/" || sign == "division")
        {
            if (number_2 != 0)
            {
                result = number_1 / number_2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero!");
                succes = false;
            }
        }
        else
        {
            Console.WriteLine("Unknown operation!");
            succes = false;
        }

        if (succes)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
