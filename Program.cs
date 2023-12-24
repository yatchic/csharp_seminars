Console.WriteLine("введите x больше ноля");
int x=int.Parse(Console.ReadLine()!);
 
while(x==0){
   Console.WriteLine("введите x больше ноля");
   x=int.Parse(Console.ReadLine()!);
}
Console.WriteLine("введите y");
  int y=int.Parse(Console.ReadLine()!);
  
  while(y==0){
   Console.WriteLine("введите y больше ноля");
   y=int.Parse(Console.ReadLine()!);
}

if(x>0&&y>0){Console.WriteLine("первая четверть");}
 if(x<0&&y>0){Console.WriteLine("вторая четверть");}
if(x<0&&y<0){Console.WriteLine("третья четверть");}
if(x>0&&y<0){Console.WriteLine("четвертая четверть");}