/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

Console.WriteLine("Введите длины сторон треугольника:");
Console.Write("a=");
int a = int.Parse(Console.ReadLine()!);

Console.Write("b=");
int b = int.Parse(Console.ReadLine()!);

Console.Write("c=");
int c = int.Parse(Console.ReadLine()!);

if (CheckT(a, b, c)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник НЕ существует");

//Метод проверки треугольника

bool CheckT(int first, int second, int third)
{
    if ((first < second + third)&&(second < first + third)&&(third < first + second)) return true;
    else return false;
}
