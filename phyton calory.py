
class FoodItem:
    def __init__(self, name, calories_per_100g):
        self.name = name
        self.calories_per_100g = calories_per_100g

    def calculate_calories(self, weight):
        return (weight / 100) * self.calories_per_100g

class Meal:
    def __init__(self, meal_name):
        self.meal_name = meal_name
        self.ingredients = []

    def add_product(self, product, weight):
        self.ingredients.append((product, weight))
        print(f"Added {weight}g {product.name} to meal: {self.meal_name}")

    def meal_calories_sum(self):
        total = 0
        for product, weight in self.ingredients:
            total += product.calculate_calories(weight)
        return total

class DailyIntake:
    def __init__(self, date):
        self.date = date
        self.meals = []

    def add_meal(self, meal):
        self.meals.append(meal)

    def display_summary(self):
        print(f"\n--- Day summary: {self.date} ---")
        day_sum = 0
        for m in self.meals:
            calories = m.meal_calories_sum()
            day_sum += calories
            print(f"{m.meal_name}: {calories:.2f} kcal")
        
        print(f"TOTAL INTAKE: {day_sum:.2f} kcal")

bread = FoodItem("Rye bread", 250)
butter = FoodItem("Butter", 717)
chicken = FoodItem("Chicken breast", 165)
rice = FoodItem("Rice", 350)
tomato = FoodItem("Tomato", 18)
cottage_cheese = FoodItem("Cottage cheese", 100)

breakfast = Meal("Breakfast")
breakfast.add_product(bread, 100)
breakfast.add_product(butter, 10)

lunch = Meal("Lunch")
lunch.add_product(chicken, 200)
lunch.add_product(rice, 50)
lunch.add_product(tomato, 150)

dinner = Meal("Dinner")
dinner.add_product(cottage_cheese, 150)
dinner.add_product(tomato, 100)

day = DailyIntake("2026-04-10")
day.add_meal(breakfast)
day.add_meal(lunch)
day.add_meal(dinner)

day.display_summary()
