﻿ 

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}


 void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


 int myFunction(int [] arr)
  {
int count=0;
for(int i=0;i<arr.Length;i++){
    if(arr[i]%7==0 && arr[i]%10==1){
        count++;

    }

}
return count;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int result=myFunction(mass);
Console.WriteLine(result);



 
