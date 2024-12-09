Console.Write("Enter your number: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Your number is even.");
}
else
{
    Console.WriteLine("Your number is odd.");
}


Console.ReadKey();