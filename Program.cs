Console.WriteLine("введите число от 10 до 99");
int digit=int.Parse(Console.ReadLine()!);
while (digit<10&&digit>99)
{
    Console.WriteLine("введено неверное чесло");
    Console.WriteLine("введите число от 10 до 99");
int digit=int.Parse(Console.ReadLine()!);
}

int integral=digit/10;
int remainder=digit%10;
if(integral>=remainder){Console.WriteLine(integral);}
else{Console.WriteLine(remainder);}