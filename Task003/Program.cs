/*
**Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(Convert(number));

string Convert(int number)
{
    int system = 2;
    string result = "";
    int res = 0;
    while (number >= 1 )
    {
        res = number % system;
        number = number / system;
        result = result + res.ToString();
    }
    string temp = result;
    result = "";
    for (int i = 0; i < temp.Length; i++)
    {
       result += temp[temp.Length-i-1];
    }
    return result;
}



//НЕ МОЙ ВАРИАНТ


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int system = 2;

// Console.WriteLine(ConvertToDouble(number, system));

//Метод 1
// string ConvertToDouble(int number, int system){
//     string result = "";
//     string tempString = "";
//     int ost = 0;

//     while (number >= 1){
//         ost = number % system;
//         number /= system;
//         tempString += ost.ToString();
//     }
    
//     for(int i = 0; i < tempString.Length; i++){
//         result += tempString[tempString.Length - i - 1];
//     }
// return result;
// }
 
// //Метод 2
// //Console.WriteLine(Convert.ToString(number, 2));
