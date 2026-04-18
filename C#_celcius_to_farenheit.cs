using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to converter C# Celsius to Fahrenheit!");

        Console.WriteLine("Choose what you want to do\n\nPress 1: Convert Celsius to Fahrenheit\nPress 2: Convert Fahrenheit to Celsius");
        
        int choose = int.Parse(Console.ReadLine());

        if (choose == 1)
        {
            Console.WriteLine("Convert Celsius to Fahrenheit, enter value: ");
            float celsius = float.Parse(Console.ReadLine());
            float result = celsius * 1.8f + 32;
            Console.WriteLine($"{celsius}°C is {result}F");
        }
        else if (choose == 2)
        {
            Console.WriteLine("Convert Fahrenheit to Celsius, enter value: ");
            float fahrenheit = float.Parse(Console.ReadLine());
            float result = (fahrenheit - 32) / 1.8f;
            Console.WriteLine($"{fahrenheit}F is {result}°C");
        }
        else 
        {
            Console.WriteLine("Something went wrong - choose 1 or 2");
        }
    }
}
