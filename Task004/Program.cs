/*
**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3

Если N = 3 -> 0 1 1

Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите размерность числа Фибонначи: ");
int num = int.Parse(Console.ReadLine()!);

int[] array = Fibonachi(num);
Console.WriteLine(String.Join(" ", array));

// Выведите первые N чисел фибанначи

int[] Fibonachi(int N)
{
    int[] arr = new int[N];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < N; i++)
    {
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}



/*
// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите размерность Вашего числа Фибоначи");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(String.Join(",", fibonachi(N)));


//method
// string fibonachi(int N){
//     string res = "0";
//     res += "1";

//     for(int i = 2; i < N; i++){
//         int something = (Convert.ToInt32(res[i-1].ToString()) + Convert.ToInt32(res[i-2].ToString()));
//         res += something.ToString();
//     }
//     return res;
// }



int[] fibonachi(int N){
    int[] res = new int[N];
    res[0] = 0;
    res[1] = 1;
    for(int i = 2; i < N; i++){
        res[i] = res[i-1] + res[i-2];
    }
    return res;
}




*/