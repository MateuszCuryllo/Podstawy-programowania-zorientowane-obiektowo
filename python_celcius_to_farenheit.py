
print(32 * "*" + "\nWelcome to temperature converter\n" + 32 * "*")

convert = int(input("To choose:\n Press 1 if you want degrees Celsius to Fahrenheit\n Press 2 if you want degrees Fahrenheit to Celsius\n: "))

if convert == 1:
    celsius = float(input("Changing degrees Celsius to Fahrenheit\n How many degrees: "))
    fahrenheit = (celsius * 1.8) + 32
    print(f"Result: {celsius}°C is {fahrenheit}°F")

elif convert == 2:
    fahrenheit = float(input("Changing Fahrenheit to Celsius degrees\n How many degrees: "))
    celsius = (fahrenheit - 32) / 1.8
    print(f"Result: {fahrenheit}°F is {celsius}°C")

else:
    print("Impossible task, try again")
