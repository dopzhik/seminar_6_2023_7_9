/*Задача 4: Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.*/

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

int [] ReturnMass(int [] array)
{
    int [] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array2[i] = array [i];
    }
    return array2;   
}

/*int num1 = ReadInt("Введите размер 1 массива");
int [] arrayone = GenerateArray(num1, -9, 9);
PrintArray(arrayone);
int [] arraytwo = ReturnMass(arrayone);
arrayone[0] = 1000;
PrintArray(arraytwo);*/
int Max(int [] array, int index)
{
       for (int i = index; i < array.Length; i++)
    {
        if (array[i] > array[index])
        {
            index = i;
        }
    }
    return index;
}

void Swap(int [] array, int index1, int index2)
{
    int temp = array [index1];
    array [index1] = array [index2];
    array[index2] = temp;
}

int [] SortMax(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int currentmax = Max(array, i);
        Swap(array, i, currentmax);
    }
    return array;
}
int num1 = ReadInt("Введите размер массива => ");
int [] arrayone = GenerateArray(num1, -9, 9);
PrintArray(arrayone);
PrintArray(SortMax(arrayone));