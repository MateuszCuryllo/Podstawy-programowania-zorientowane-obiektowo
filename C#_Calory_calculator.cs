using System;
using System.Collections.Generic;

public class FoodItem
{
    public string Name;
    public int Calory;

    public FoodItem(string name, int calory)
    {
        Name = name;
        Calory = calory;
    }
}
public class Meal
{
    public string Name;
    public List<FoodItem> Items = new List<FoodItem>();

    public Meal(string n) { Name = n; }

    public int Calculate_calory()
    {
        int suma = 0;
        for (int i = 0; i < Items.Count; i++)
        {
            suma += Items[i].Calory;
        }
        return suma;
    }
}

public class DailyIntake
{
    public List<Meal> Meals = new List<Meal>();

    public int Day_sum()
    {
        int total = 0;
        for (int i = 0; i < Meals.Count; i++)
        {
            total += Meals[i].Calculate_calory();
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        DailyIntake today = new DailyIntake();

        Meal breakfast = new Meal("Breakfast");
        breakfast.Items.Add(new FoodItem("Egg", 70));
        breakfast.Items.Add(new FoodItem("Toast", 100));
        today.Meals.Add(breakfast);

        Meal lunch = new Meal("Lunch");
        lunch.Items.Add(new FoodItem("Chicken Breast", 200));
        lunch.Items.Add(new FoodItem("Rice", 300));
        today.Meals.Add(lunch);

        Meal dinner = new Meal("Dinner");
        dinner.Items.Add(new FoodItem("Cottage Cheese", 120));
        dinner.Items.Add(new FoodItem("Tomato", 20));
        today.Meals.Add(dinner);

        int totalCalories = today.Day_sum();

        Console.WriteLine("=== DZIENNY LICZNIK KALORII (Wersja z pętlą FOR) ===");
        Console.WriteLine($"Breakfast:{breakfast.Calculate_calory()} kcal");
        Console.WriteLine($"Lunch:{lunch.Calculate_calory()} kcal");
        Console.WriteLine($"Dinner:{dinner.Calculate_calory()} kcal");
        Console.WriteLine($"TOTAL TODAY: {totalCalories} kcal");
    }
}