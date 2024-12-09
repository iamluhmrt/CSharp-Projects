// Switch = an efficient alternative to many else if statements

Console.Write("What day is it today?");
string day = Console.ReadLine();

switch (day)
{
    case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuesday":
        Console.WriteLine("Its Tuesday");
        break;
    case "Wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    case "Thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "Friday":
        Console.WriteLine("Its Friday!");
        break;
    case "Saturday":
        Console.WriteLine("Its Saturday!");
        break;
    case "Sunday":
        Console.WriteLine("It's Sunday!");
        break;
    default:
        Console.WriteLine(day + " is not a day!");
        break;
}

Console.ReadKey();
