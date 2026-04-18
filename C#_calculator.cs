﻿using System;

class Program
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        Console.Write("Welcome to the Calculator\n\nPlease give me the first number: ");
        float number_1 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nChoose what you want to do:\n - subtraction\n + addition\n * multiplication\n / division");
        string sign = Console.ReadLine();

        Console.WriteLine("Please give me a second number:");
        float number_2 = float.Parse(Console.ReadLine());
        
        float result = 0;
        bool success = true;
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
                success = false;
            }
        }
        else
        {
            Console.WriteLine("Unknown operation!");
            success = false;
        }
        if (success == true)
        {
            Console.WriteLine($"Result: {result}");
        }
    }
}
