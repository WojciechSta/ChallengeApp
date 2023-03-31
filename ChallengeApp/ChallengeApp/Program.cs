﻿using ChallengeApp;
using System.ComponentModel.DataAnnotations;


Console.WriteLine("Witamy w Programie do oceny Pracowników ");
Console.WriteLine("=========================================== ");
Console.WriteLine();


var employee = new Employee("Jan", "Tyczka");

while (true) 
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Average:{statistics.Average}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
Console.WriteLine($"AverageLetter:{statistics.AverageLetter}");


