// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Collections.Generic;

Console.WriteLine("Enter comma-separated numbers:");
var input = Console.ReadLine();

var parts = input?.Split(',', StringSplitOptions.RemoveEmptyEntries);
var numbers = new List<int>();

if (parts != null)
{
    foreach (var p in parts)
    {
        if (int.TryParse(p.Trim(), out int n))
            numbers.Add(n);
        else
            Console.WriteLine($"Invalid: {p}");
    }
}

Console.WriteLine($"Count: {numbers.Count}");
Console.WriteLine($"Min: {numbers.Min()}");
Console.WriteLine($"Max: {numbers.Max()}");
Console.WriteLine($"Average: {numbers.Average()}");

// Sum even > 10
Console.WriteLine($"Sum Even > 10: {numbers.Where(n => n % 2 == 0 && n > 10).Sum()}");

// Unique numbers
Console.WriteLine($"Unique Count: {numbers.Distinct().Count()}");

// Second largest distinct
var distinct = numbers.Distinct().OrderByDescending(n => n).ToList();
Console.WriteLine($"Second Largest: {(distinct.Count >= 2 ? distinct[1] : (int?)null)}");

