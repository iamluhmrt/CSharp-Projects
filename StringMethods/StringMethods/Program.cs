string fullName = "Jesus Is The Savior";
// fullName = fullName.ToUpper(); JESUS IS THE SAVIOR
// fullName = fullName.ToLower(); jesus is the savior
// fullName = fullName.Insert(0, "@"); @Jesus Is The Savior

string phoneNumber = "123-456-7890";
// phoneNumber = phoneNumber.Replace("-", ""); 123456790 

int lengthName = fullName.Length; // Property "19" characters
// Console.WriteLine(lengthName);

string firstName = fullName.Substring(0, 5); // start at 0, want 5 characters.
string lastName = fullName.Substring(13, 6); // start at 13, want 6 characters.

Console.ReadKey();