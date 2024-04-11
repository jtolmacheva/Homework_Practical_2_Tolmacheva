/* Задача 1: Напишите программу, которая принимает 
на вход число и проверяет, кратно ли оно 
одновременно 7 и 23 */

void MultipleOfNumber (int num)
{
    int seven = num / 7;
    int twentyThree = num / 23;

    if (seven * 7 == num && twentyThree * 23 == num)
    {
        System.Console.WriteLine($"{num} -> yes");
    }
    else
    {
        System.Console.WriteLine($"{num} -> no");
    }
}

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

MultipleOfNumber (num);

