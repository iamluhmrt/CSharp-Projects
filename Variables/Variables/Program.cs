int x; // Declaration
x = 33; // Initialization
int y = 3; // Declaration and Initialization

// Console.WriteLine(x);
// Console.WriteLine(y);

// Addition
int z = x + y;
// Console.WriteLine(z);

// Data Type
int age = 23; // Whole Integer 
Console.WriteLine("Your age is " + age);

double height = 1.87; // Decimal Number
Console.WriteLine("Your height is " + height + "cm");

bool happy = true; // True or False
Console.WriteLine("Are you happy? " + happy);

char symbol = '@'; // Single character
Console.WriteLine("Your gmail account is email" + symbol + "gmail.com");

string name = "Bro";
string username = name + symbol;
Console.WriteLine("Your username is: " + username);

/* Constants = immutable values 
 * which are known at compile time
 * and do not change for the life of the program
 */

const double pi = 3.14159;
Console.WriteLine(pi);

Console.ReadKey();