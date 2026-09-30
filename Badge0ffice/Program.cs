using System.Diagnostics.Contracts;

System.Console.Write("Hello, please input your full name: ");

string? fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

fullName = fullName.ToUpper();

char firstInitial = Convert.ToChar(firstName.Substring(0, 1));
firstInitial = char.ToUpper(firstInitial);

char lastInitial = Convert.ToChar(lastName.Substring(0, 1));
lastInitial = char.ToUpper(lastInitial);

string userName = Convert.ToString(firstInitial) + lastName;
userName = userName.ToLower();

int totalLetters = lastName.Length;

System.Console.WriteLine($"Name on Badge: {fullName}");
System.Console.WriteLine($"Username: {userName}");
System.Console.WriteLine($"Initials: {firstInitial}.{lastInitial}.");
System.Console.WriteLine($"Letters in last name: {totalLetters}");
