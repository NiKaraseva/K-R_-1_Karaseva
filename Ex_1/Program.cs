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
Console.WriteLine();

int size = SizeArray(array);
Console.WriteLine($"Размер итогового массива = {size}");


string[] array2 = NewArray(array, size);
Console.WriteLine("Итоговый массив:[" + string.Join(", ", array2) + "]");


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

string[] NewArray(string[] array, int size)
{
    string[] result = new string[size];
    int length;
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        length = array[i].Length;
        if(length <= 3)
        {
            result[j] = array[i];
            j++;
        }           
        
    }
    return result;
}