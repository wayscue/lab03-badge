/*
* Name: William Ayscue
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.

Part 1: The Name
*/

using System.Text.RegularExpressions;

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

/*
Part 2: The Numbers
*/

Random rando = new Random();

int stuID = rando.Next(100000, 1000000);
int lockerID = rando.Next(1, 501);

System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine($"Student ID: {stuID}");
System.Console.WriteLine($"Locker: {lockerID}");

/*
Part 3: The Walk
*/

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.Write("What is the X location of your classroom? ");
int classX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the Y location of your classroom? ");
int classY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the X location of your dorm? ");
int doormX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is the Y location of your dorm? ");
int doormY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What is your walking speed in feet per second? ");
double walkSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((doormX - classX),2) + Math.Pow((doormY - classY),2));

System.Console.WriteLine(distance);

int time = Convert.ToInt32(distance / walkSpeed);
int timeMin = Convert.ToInt32(time/60);
int timeSec = Convert.ToInt32(time % 60);

System.Console.WriteLine($"Distance: {distance.ToString("F1")}");
System.Console.WriteLine($"Walk time: {timeMin} minutes {timeSec} seconds");

/*
Part 4: The Badge
*/

int checkDigit = stuID % 9;

System.Console.WriteLine();
System.Console.WriteLine();

System.Console.WriteLine("==================================");
System.Console.WriteLine("        ETSU STUDENT BADGE        ");
System.Console.WriteLine("==================================");

System.Console.WriteLine($"NAME {fullName.PadLeft(18)}");

System.Console.WriteLine($"USERNAME {userName.PadLeft(11)}");

System.Console.WriteLine($"ID{ Convert.ToString(stuID).PadLeft(15)}-{checkDigit}");

System.Console.WriteLine($"LOCKER {Convert.ToString(lockerID).PadLeft(7)}");

System.Console.WriteLine($"WALK {Convert.ToString(timeMin).PadLeft(7)} min {timeSec} sec");

System.Console.WriteLine("==================================");
