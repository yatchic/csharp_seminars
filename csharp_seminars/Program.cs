Console.WriteLine("\nначало программы");
Random rnd = new Random();
int rand_number = rnd.Next(1, 100000);
Console.Write($"Случайное число = {rand_number}");

int size = 0;
int div = rand_number / 10;
if(div > 0) {
    size++;
}
while(div > 0) {
    div = div / 10;
    if(div > 0) {
        size++;
    }
}
size++;
Console.Write($"\nКоличество цифр = {size}");

int rest = 0;
div = 10000;
int[] arr = new int[size];
for(int i = 0; i < arr.Length; i++){
    if(i == 0){
        rest = rand_number % div;
        arr[i] = rand_number / div;
    } else {
        rand_number = rest;
        div = div / 10;
        rest = rand_number % div;
        arr[i] = rand_number / div;
    }
}
 Console.WriteLine($"\nразмер массива={arr.Length}");
 Console.Write("массив:");
for(int i = 0; i < arr.Length; i++){Console.Write($"{arr[i]} ");}
 for(int i = 0; i < arr.Length; i++){
    for(int j = i + 1; j < arr.Length; j++){
        
        if(arr[i] < arr[j]){
             
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
 Console.WriteLine("");

Console.Write("отсортированный массив:");
for(int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]} ");
}
Console.WriteLine("\nконец программы");