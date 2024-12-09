Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the operation (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

double result;

if (operation == '+')
{
    result = num1 + num2;
    Console.WriteLine("Result: " + result);
}
else if (operation == '-')
{
    result = num1 - num2;
    Console.WriteLine("Result: " + result);
}
else if (operation == '*')
{
    result = num1 * num2;
    Console.WriteLine("Result: " + result);
}
else if (operation == '/')
{
    if (num2 != 0)
    {
        result = num1 / num2;
        Console.WriteLine("Result: " + result);
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operation. Please enter one of (+, -, *, /).");
}


Console.ReadKey();