/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void Print (string text){  
   Console.Write(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] GenerateArray(int length, int minValue, int maxValue){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array){
    Print("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Print($"{array[i]}, ");
    }
    Print($"{array[array.Length - 1]}] ");
}

Print("Длина массива: ");
int length = GetIntNum();
Print("Начальное значение, для диапазона случайного числа: ");
int min = GetIntNum();
Print("Кончное значение, для диапазона случайного числа: ");
int max = GetIntNum();
int[] array = GenerateArray(length, min, max);
PrintArray(array);