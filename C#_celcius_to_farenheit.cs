Console.WriteLine("Welcom in converter C# Celcius to Farenheit!");

Console.WriteLine("choose what you want to do\n \nPres 1 Conwert Celcius to Farenheit\nPres 2 Convert Farenheit to Celcius  ");
int choos = int.Parse(Console.ReadLine());



if  (choose == 1)
{
    Console.WriteLine($"Conwert Celcius to Farenheit enter value:  ");
    float celcius =float.Parse(Console.ReadLine());
    float result =celcius * 1.8f + 32 ;
    Console.WriteLine($"{celcius}°C is {result}F");
}
if  (choose == 2)
{
    Console.WriteLine($"Convert Farenheit to Celcius enter value:  ");
    float farenheit= float.Parse(Console.ReadLine());
    float resut = (farenheit - 32) / 1.8f;
    Console.WriteLine($"{farenheit}F is {resut}°C ");
}
else 
{
    Console.WriteLine("sometching went wrong");
}
