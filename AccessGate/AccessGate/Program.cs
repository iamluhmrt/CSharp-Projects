// Access Gate
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Your access is allowed.");
}
else
{
    Console.WriteLine("Acess denied, you must be 18 or older.");
}

Console.ReadKey();