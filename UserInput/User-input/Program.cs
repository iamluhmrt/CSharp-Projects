// User Input

Console.Write("What's your first name? ");
string name = Console.ReadLine();

Console.Write("What's your last name? ");
string lastname = Console.ReadLine();

Console.Write("What's your ID number? ");
int id = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Name: " + name + " " + lastname + " Id:" + id);

Console.ReadKey();