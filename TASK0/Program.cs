// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min,max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int[] Reverse(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

int len = ReadInt("Введите длину массива > ");
int[] array = GenerateArray(len, 0, 10);
PrintArray(array);
PrintArray(Reverse(array));