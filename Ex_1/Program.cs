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

int size = SizeArray(array);
Console.WriteLine($"Размер итогового массива = {size}");
Console.WriteLine();

int SizeArray(string[] array)
{
    int size = 0;
    int length;
    for(int i = 0; i < array.Length; i++)
    {
        length = array[i].Length;
        if(length <= 3)
        {
            size++;
        }
    }
    return size;
}