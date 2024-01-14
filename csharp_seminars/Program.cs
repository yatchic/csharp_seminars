 
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

int[] perevorotMassiva(int[] arr) {
    int buf = 0;
    if(arr.Length%2==0){for (int i = 0; i < arr.Length / 2; i++) {
        buf = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = buf;
    }}else{
        for (int i = 0; i < arr.Length / 2; i++) {
        buf = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = buf;
    }
    }
    return arr;
}
        Console.WriteLine("введите размер массива");
      int size = int.Parse(Console.ReadLine());

      int[]arr=MassNums(size, 1, 100);
      Print(arr);
        int[] arrPerevernutiy=perevorotMassiva(arr);
        Console.WriteLine("");
        Print(arrPerevernutiy);
