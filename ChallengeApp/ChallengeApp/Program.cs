using ChallengeApp;
using System.Globalization;

var employee = new ChallengeApp.Employee("Jan", "Tyczka");
employee.AddGrade("Jan");
employee.AddGrade("2000");
employee.AddGrade(2);
employee.AddGrade(12.5);
employee.AddGrade(5.5f);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {(statistics.Min)}");
Console.WriteLine($"Max: {statistics.Max}");