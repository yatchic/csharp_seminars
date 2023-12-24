
Console.WriteLine("введите x");
int x=int.Parse(Console.ReadLine()!);
Console.WriteLine("введите y");
int y=int.Parse(Console.ReadLine()!);
if(x>0&&y>0){Console.WriteLine("первая четверть");}
 if(x<0&&y>0){Console.WriteLine("вторая четверть");}
if(x<0&&y<0){Console.WriteLine("третья четверть");}
if(x>0&&y<0){Console.WriteLine("четвертая четверть");}


