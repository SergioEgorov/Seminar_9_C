int N = int.Parse(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start+1, end));
}

Console.WriteLine(PrintNumbers(1, N));