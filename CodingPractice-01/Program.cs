using System;

//Transformer square = x => x * x;
//Console.WriteLine(square(3));
//Console.WriteLine(square(4));

//delegate int Transformer(int i);
//3
//IsLonger islong = (string msg, int len) => msg.Length > len;
//Console.WriteLine(islong("안녕하세요.", 5));
//Console.WriteLine(islong("반갑습니다.", 10));
//delegate bool IsLonger(string msg, int len);
//4
//Greeting greeting = () =>
//{
//    Console.WriteLine("안녕하세요.");
//    Console.WriteLine("반갑습니다.");
//};
//greeting();
//delegate void Greeting();
Calculator add = (a, b) =>
{
    int result = a + b;
    Console.WriteLine($"{a} + {b} = {result}");
    return result;
};
int sum = add(3, 5);
Console.WriteLine($"합계: {sum}");
delegate int Calculator(int a, int b);