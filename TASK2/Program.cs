/*Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

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

int [] ConvertBinnary(int num)
{
    int[] binary = new int [8];
    int i = binary.Length - 1;
    while (num > 0)
    {
        binary[i] = num % 2;
        i--;
        num /= 2;
    }
    return binary;
}

int number = ReadInt("Введите число => ");
int [] currentarray = ConvertBinnary(number);
PrintArray(currentarray);