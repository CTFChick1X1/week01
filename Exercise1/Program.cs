// See https://aka.ms/new-console-template for more information

string firstname;
string lastname;

Console.Write("Enter your first name: ");
firstname = Console.ReadLine() ?? "Unknown";

Console.Write("Enter your last name: ");
lastname = Console.ReadLine() ?? "Unknown";

Console.WriteLine($"Hello, {firstname} {lastname}!");
