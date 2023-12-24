
int digit=int.Parse(Console.ReadLine()!);
Random rnd = new Random(digit);
int value = rnd.Next(10,99);
Console.WriteLine($"случайное число от 10 до 99 : {value}");
int integral=value/10;
int remainder=value%10;
if(integral>=remainder){Console.WriteLine(integral);}
else{Console.WriteLine(remainder);}



