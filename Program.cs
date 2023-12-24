Console.WriteLine("введите число");
int digit = int.Parse(Console.ReadLine()!);
if (digit < 10)
{
    Console.WriteLine(digit);
}
else
{
    string s = digit.ToString();
    for (int i = 0; i <= s.Length - 1; i++)
    {
        if (i == s.Length - 1)
        {
            Console.Write(s[i]);
        }
        else
        {
            Console.Write($"{s[i]},");
        }
    }
}
