using System;
using System.Collections.Generic;

var multiplesOf3 = FindNumbers(n => n % 3 == 0);
Console.WriteLine("3의 배수:");
foreach (var n in multiplesOf3)
{
    Console.Write($"{n} ");
}
Console.WriteLine();

Console.WriteLine("제곱수:");
var PerfectSquare = FindNumbers(n =>
{
    int sqrt = (int)Math.Sqrt(n);
    return sqrt * sqrt == n;
});
foreach (var i in PerfectSquare)
{
    Console.Write($"{i} ");
}
static List<int> FindNumbers(Predicate<int> predicate)
{ 
    List<int> result = new List<int>();
    for (int i = 0; i <= 100; i++)
    {
        if (predicate(i))
        { 
            result.Add(i);
        }
    }
    return result;
}
Console.WriteLine();
//2
Predicate<int> isEven = x => x % 2 == 0;
Console.WriteLine(isEven(4));
Func<int,bool> isOdd = x => x % 2 == 1;
Console.WriteLine(isOdd(4));
//3
int factor = 2;
Func<int, int> multiplier = n => n * factor;
Console.WriteLine(multiplier(3));

factor = 10;
Console.WriteLine(multiplier(3));
//4
int count = 0;
Action increment = () => count++;
increment();
increment();
increment();
Console.WriteLine(count);

//5
var counter = CreateCounter();
Console.WriteLine(counter());
Console.WriteLine(counter());
Console.WriteLine(counter());
static Func<int> CreateCounter()
{
    int count = 0;
    return () => count++;
}