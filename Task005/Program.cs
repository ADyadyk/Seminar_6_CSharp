/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
(Можно изучить метод Split. 
Пример: stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);,
где первый аргумент это разделитель чисел, второе обработчик введеной последовательности)

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

//Методо, который запрашивает последовательность чисел (через пробел)
//и преобразует их в массив, убирая разделительные пробелы:

string[] GetNumbers()
{
Console.Write("Введите последовательность чисел разделяя их пробелом: ");
string numbers = Console.ReadLine();

string[] num = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
return num;
}


//Метод, который проверяет сколько чисел больше нуля ввёл пользователь
int CountPositivNumbers(string[] nm)
{
    int count = 0;
    for (int i = 0; i < nm.Length; i++)
    {
        int k = int.Parse(nm[i]);
        if (k > 0) count++;
    }
    return count;
}

//Сама программа:
string[] mas = GetNumbers();
Console.WriteLine(CountPositivNumbers(mas));