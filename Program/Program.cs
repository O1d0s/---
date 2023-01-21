Console.Write("Сколько слов хотите ввести: ");
int a = int.Parse(Console.ReadLine());
if (a<0){
    Console.WriteLine("Длинна массива должна быть больше 0");
}
string[] arr = InputArray(a);
string[] mas = new string[arr.Length];
Search(arr,mas);
Console.WriteLine("Данные первого массива: ");
PrintArray(arr);
Console.WriteLine("Данные перезаписанного массива: ");
PrintArray(mas);

string[] InputArray(int a){
    string[] arr = new string[a];
    Console.WriteLine("Введите слова: ");
    for(int i=0;i<a;i++){
        arr[i] = Console.ReadLine();
    }
    return arr;
}


void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Search(string[] arr, string[] mas){
    int chet = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            mas[chet] = arr[i];
            chet++;           
        }
    }
}