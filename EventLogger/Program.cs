using System;
Action<string> sLogger = CreateLogger("시스템");
Action<string> nLogger = CreateLogger("네트워크");

sLogger("서버를 시작합니다.");
sLogger("초기화가 완료되었습니다.");
nLogger("클라이언트가 접속했습니다.");
sLogger("요청을 처리합니다.");
nLogger("데이터를 수신했습니다.");
nLogger("클라이언트가 종료했습니다.");
Action<string> CreateLogger(string category)
{
    int number = 0;
    return (message) =>
    {
        number++;
        Console.WriteLine($"[{category}/ #{number}] {message}");
    };
}