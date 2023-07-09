/*Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Triangle(int a, int b, int c)
{
    return ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0));
}

int a = ReadInt("Введите сторону a => ");
int b = ReadInt("Введите сторону b => ");
int c = ReadInt("Введите сторону c => ");

if (Triangle(a, b, c))
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} не существует");
}