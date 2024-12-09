Console.Write("Enter a note between 0 and 100: ");
double note = Convert.ToDouble(Console.ReadLine());

if (note >= 90 && note <= 100)
{
    Console.WriteLine("Your grade is A (90-100): " + note);
}
else if (note >= 80 && note <= 89)
{
    Console.WriteLine("Your grade is B (80-89): " + note);
}
else if (note >= 70 && note <= 79)
{
    Console.WriteLine("Your grade is C (70-79): " + note);
}
else if (note >= 60 && note <= 69)
{
    Console.WriteLine("Your grade is D (60-69): " + note);
}
else if (note >= 0 && note < 60)
{
    Console.WriteLine("Your grade is F (below 60): " + note);
}
else
{
    Console.WriteLine("Invalid note. Please enter a value between 0 and 100.");
}

Console.ReadKey(); 

