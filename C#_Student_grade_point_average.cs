using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the student GPA calculator!\n");
        Console.Write("how many grades do you have: ");

        int number = int.Parse(Console.ReadLine());
        float total = 0;

        for (int i = 0; i < number; i++) 
        {
            Console.Write($"Enter your grades:\n{i+1}) ");
            float grades = float.Parse(Console.ReadLine().Replace('.', ','));
            total += grades;
        }

        float GPA = total / number;
        
        Console.Write($"Your GPA is: {GPA:F2}");
    }

