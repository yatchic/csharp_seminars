 
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int numberOfEvenNumbers(int[]arr){
    int count=0;
      for(int i=0;i<arr.Length;i++){
          if(arr[i]%2==0){count++;}

      }
     return count;  

}

      int[]arr=MassNums(10, 100, 999);
      Print(arr);
        int count=numberOfEvenNumbers(arr);
        Console.WriteLine($"четных чисел={count}");
