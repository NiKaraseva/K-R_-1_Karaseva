Console.WriteLine("Задайте длину массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);

string[] array = new string[n];
for(int i = 0; i < n; i++)
{
    Console.Write("Введите элемент массива: ");
    array[i] = Console.ReadLine()!;
} 
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");