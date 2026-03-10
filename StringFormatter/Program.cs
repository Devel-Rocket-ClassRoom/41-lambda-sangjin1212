using System;
Func<string, string> toUpper = msg => msg.ToUpper();

Func<string, string> greet = msg => $"안녕{msg}";
static void ApplyAndPrint(string input, Func<string,string>formaatter)
{
    string result = formaatter(input);
    Console.WriteLine($"{input} -> {result}");
}
Console.Write("[대문자 변환]");
ApplyAndPrint("hello world",toUpper);
Console.Write("[인사말 생성]");
Console.WriteLine("민수", greet);