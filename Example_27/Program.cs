/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
void Print (string text){  
   Console.Write(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumAllDigit(int number){
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
Print("Введите число => ");
int number = GetIntNum();
Print($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");