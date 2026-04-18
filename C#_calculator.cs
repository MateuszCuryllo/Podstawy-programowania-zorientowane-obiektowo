Console.Write("Welcome in Calculator\n \nPlis give me first number: "); 
float number_1 = float.Parse(Console.ReadLine());

 Console.WriteLine("Chose what you want to do:\n - subtraction\n + addition\n * multiplication\n / division\n");
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
        number_2 = 0;
        {
            Console.WriteLine("do not divine by 0");
            succes = false;
        }
    }
}
else
{
    Console.WriteLine("sometching went wrong :{ try again ");
    succes= false;
}
if (succes)
{
    Console.WriteLine($"result: {result}");
}
