Console.Write("Сколько слов хотите ввести: ");
int a = int.Parse(Console.ReadLine());
string[] arr = InputArray(a);
string[] mas = new string[arr.Length];

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
