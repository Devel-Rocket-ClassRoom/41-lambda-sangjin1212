using System;
using System.Net.Http;
//1
Func<int> number = () => 1234;
Console.WriteLine(number());
Func<int, int> square = x => x * x;
Console.WriteLine(square(3));
Func<int, int, int> add = (x, y) => x + y;
Console.WriteLine(add(3, 5));
//2
Action msg = () => Console.WriteLine("안녕하세요!");
msg();
Action<string> text = message => Console.WriteLine(message);
text("Hello, Lambda!");
Action<string, int> repeat = (msg1, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg1);
    }
};
repeat("반복!", 3);
//3
Func<int,int> anonymous = delegate (int x) { return x * x; };
Console.WriteLine(anonymous(2));

Func<int, int> lambda = x => x * x;
Console.WriteLine(lambda(2));