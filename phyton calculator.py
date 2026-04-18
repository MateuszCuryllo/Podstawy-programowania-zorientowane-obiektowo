print("*" * 27+"\nWelcome to simple Calculator\n"+"*" * 27)

number1 = float(input("\nGive me a first number: "))
choice = input("Choose an action (+ - * /): ")
number2 = float(input("Give me a second number: "))

if choice == "+":
    result = number1 + number2 
    print(f"Result: {number1} + {number2} = {result}")

elif choice == "-":
    result = number1 - number2
    print(f"Result: {number1} - {number2} = {result}")

elif choice == "*":
    result = number1 * number2
    print(f"Result: {number1} * {number2} = {result}")

elif choice == "/":
    if number2 == 0:
        print("Error: you cannot divide by 0")
    else:
        result = number1 / number2
        print(f"Result: {number1} / {number2} = {result}")

else:
    print("Impossible task, try again")