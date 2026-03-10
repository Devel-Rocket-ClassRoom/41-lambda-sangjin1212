using System;
using System.Collections.Generic;
//1
{ 
    Action[] actions = new Action[3];

    for (int i = 0; i < 3; i++)
    {
        actions[i] = () => Console.Write(i);
    }
    foreach (Action a in actions)
    {
        a();
    }
    Console.WriteLine();
}
//2
{
    Action[] actions = new Action[3];

    for (int i = 0; i < 3; i++)
    {
        int loopVar = i;
        actions[i] = () => Console.Write(loopVar);
    }
    foreach (Action a in actions)
    {
        a();
    }
    Console.WriteLine();
}
//3
{
    string[] names = { "김철수", "이영희", "박민수" , "최지연" };

    Array.Sort(names, (a, b) => a.Length.CompareTo(b.Length));
    Console.WriteLine("이름 길이순 정렬:");
    foreach (var n in names)
    {
        Console.WriteLine(n);
    }

    Array.Sort(names, (a, b) => b.CompareTo(a));
    Console.WriteLine("역순 정렬:");
    foreach (var n in names)
    {
        Console.WriteLine(n);
    }
}

//4
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int fristFind = numbers.Find(n => n % 2 == 0);
    Console.WriteLine($"첫번째 짝수: {fristFind}");
    List<int> evens = numbers.FindAll(n => n % 2 == 0);
    Console.WriteLine($"모든 짝수: {string.Join(", ", evens)}");
    bool hasLargeNumber = numbers.Exists(n => n > 8);
    Console.WriteLine($"8보다 큰 수 존재: {hasLargeNumber}");
    bool allPositive = numbers.TrueForAll(n => n > 0);
    Console.WriteLine($"모두 양수인지: {allPositive}");
    int remove = numbers.RemoveAll(n => n % 2 == 0);
    Console.WriteLine($"제거된 짝수 개수: {remove}");
    Console.WriteLine($"남은 숫자: {string.Join(", ", numbers)}");


}