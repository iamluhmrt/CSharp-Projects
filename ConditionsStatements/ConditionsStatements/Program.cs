// a basic form of decision making

Console.Write("Please enter your name: ");
string name = Console.ReadLine();

if (!string.IsNullOrEmpty(name))
{
    if (name.Length > 3)
    {
        Console.WriteLine("Your name is too big");
    }
    else
    {
        Console.WriteLine("Hello " + name);
    }
}
else
{
    Console.WriteLine("You did not enter your name!");
}

