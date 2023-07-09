/*Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int [] createfib(int num)
{
    int [] array = new int[num];
    array[0] = 0;
    if (num <= 1) return array;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array [i-2];
    }
    return array;
}
int number = ReadInt("Введите число =>");
PrintArray(createfib(number));
