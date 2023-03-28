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

var statistics1 = employee.GetStatistics();
Console.WriteLine("    ForEach    ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {(statistics.Min)}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics2 = employee.GetStatistics();
Console.WriteLine("    For    ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {(statistics.Min)}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics3 = employee.GetStatistics();
Console.WriteLine("    DoWhile    ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {(statistics.Min)}");
Console.WriteLine($"Max: {statistics.Max}");

var statistics4 = employee.GetStatistics();
Console.WriteLine("    While    ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {(statistics.Min)}");
Console.WriteLine($"Max: {statistics.Max}");