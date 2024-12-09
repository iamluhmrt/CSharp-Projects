// while loop = repeats some code while some condition remains true

Console.Write("Enter your name: ");
string name = Console.ReadLine();

while (name == "")
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
}

Console.WriteLine("Hello " + name + "!");



Console.ReadKey();