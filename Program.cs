// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 문제 5.1
// 콘솔에서 입력받은 문자열을 대/소문자 구별없이 같은지 조사
Console.WriteLine("문자열을 입력하세요.\r\n");

string root = Console.ReadLine();
string root2 = Console.ReadLine();

bool areEqual = String.Equals(root, root2, StringComparison.OrdinalIgnoreCase);

Console.WriteLine($"<{root}> 와 <{root2}> 는 {(areEqual ? "같습니다." : "같지 않습니다.")}");

// 문제 5.2
// 콘솔에서 입력받은 문자열을 int형으로 변환한 후 콤마로 구분된 숫자 문자열로 변환
try
{
    int result;
    if (int.TryParse(root, out result))
    {
        foreach (var r in root)
            Console.WriteLine("{0}" + ", "  + r);
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex);
}





