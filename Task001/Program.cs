/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();

int[] result = ReverseArray2(array);
Console.WriteLine(String.Join(" ", result));
Console.WriteLine();

ReverseArray1(array);
Console.WriteLine(String.Join(" ", array));

//Метод задания массива

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


// Первый метод разварота массива
void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length / 2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

// Второй метод разварота массива
int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}