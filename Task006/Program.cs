/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
Чтобы определить координаты пересечения двух прямых на координатной плоскости
необходимо решить следующую систему уравнений:

y = k1 * x + b1
y = k2 * x + b2

Вычтем из первого уравнения второе и из получившейся разности выразим x (координату пересечения):

x = (b1 - b2) / (k2 - k1)

Подставим получившиеся значение x во второе уравнение и получим y (координату пересечения):

y = k2 *((b1 - b2) / (k2 - k1)) + b2
*/


//Метод который запрашивает кооффициенты для уравнений прямых и помещает их в двумерный массив:

double[,] GetXY()
{
    Console.WriteLine("Введите коэффициенты для уравнения прямой y = k1 * x + b1");
    Console.Write("Введите k1= ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите b1= ");
    double b1 = double.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.WriteLine("Введите коэффициенты для уравнения прямой y = k2 * x + b2");
    Console.Write("Введите k2= ");
    double k2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите b2= ");
    double b2 = double.Parse(Console.ReadLine()!);

    double[,] xyMas = new double[2,2];
    xyMas[0,0] = k1;
    xyMas[0,1] = b1;
    xyMas[1,0] = k2;
    xyMas[1,1] = b2;
    return xyMas;
}

//Метод, который проверяет параллельны ли две заданные прямые:
//Две прямые не пересекаются когда их угловые коэффициенты равны k1 = k2

bool CheckLine(double[,] m)
{
    if (m[0,0] != m[1,0]) return true;
    else return false;
}


//Метод, который находит точку пересечения двух прямых

void IntersectionPoint(double[,] ms)
{
    if (CheckLine(ms))
    {
    double x = (ms[0,1] - ms[1,1])/(ms[1,0] - ms[0,0]);
    double y = ms[1,0] * x + ms[1,1];
    Console.WriteLine($"Координаты точки пересечения двух прямых: х={x} y={y}");
    }
    else Console.WriteLine("Две данные прямые не пересекаются.");
}

//Сама программа

IntersectionPoint(GetXY());