/* type casting = Converting a value to a different data type
 * Useful when we accept user input (string)
 * Different data types can do different things
 */

int a = 33;
double b = Convert.ToDouble(a);

double c = 33.333;
int d = Convert.ToInt32(c);

int e = 33;
string f = Convert.ToString(e);

string g = "$";
char h = Convert.ToChar(g);

string i = "true";
bool j = Convert.ToBoolean(i);

Console.WriteLine(b.GetType());
Console.WriteLine(d.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(h.GetType());
Console.WriteLine(j.GetType());