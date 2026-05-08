using System.ComponentModel;

Console.WriteLine("Hello, World!");
Console.WriteLine($"The current time is {DateTime.Now}");
DateTime today = DateTime.Today;
DateTime christmas = new DateTime(today.Year, 12, 25);
if (christmas < today)
{
  christmas = new DateTime(today.Year + 1, 12, 25);
}
int daysUntil = (christmas - today).Days;
Console.WriteLine($"There are {daysUntil} days until Christmas!");