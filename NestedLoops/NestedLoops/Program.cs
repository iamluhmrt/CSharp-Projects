// nested loops = loops inside of other loops
// Uses vary. Used a lot in sorting algorithms.

Console.Write("How many rows? ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("How many colums? ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("What symbol? ");
string symbol = Console.ReadLine();

for (int i = 0; i < rows; i++) // outer loop
{
    for(int j = 0; j < columns; j++) // inner loop
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}

Console.ReadKey();