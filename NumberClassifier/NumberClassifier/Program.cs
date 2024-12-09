// Number Classifier
Console.Write("Enter a Number: ");
double userNumber = Convert.ToDouble(Console.ReadLine());

if (userNumber == 0)
{
    Console.WriteLine("The number is zero");
}
else if (userNumber < 0)
{
    Console.WriteLine("The number is negative");
}
else
{
    Console.WriteLine("The number is positive");
}

Console.ReadKey();