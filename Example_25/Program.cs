/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void Print (string text){  
   Console.Write(text); 
}

int GetIntNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidatePower(int power){
    if (power < 0){
        Print("Показатель степени не должен быть меньше нуля");
        return false;
    }
    return true;
}
Print("Введите число A (основание)=> ");
int aBase = GetIntNum();
Print("Введите число B (показатель степени)=> ");
int bPower = GetIntNum();
if (ValidatePower(bPower))
{
    Print($"Число {aBase} в степени {bPower} = {Math.Pow(aBase, bPower)}");
}