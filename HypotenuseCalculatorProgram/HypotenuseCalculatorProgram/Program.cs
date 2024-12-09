Console.Write("Enter side A: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side B: ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Pow(a, 2); 
double d = Math.Pow(b, 2);
double e = Math.Sqrt(c + d);

double f = Math.Sqrt((a * a) + (b * b)); // shortest solution
Console.WriteLine("The Hypotenuse of " + a + " and " + b + " is: " + f);