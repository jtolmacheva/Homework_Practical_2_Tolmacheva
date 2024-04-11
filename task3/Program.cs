/* Задача 3: Напишите программу, которая принимает 
на вход целое число из отрезка [10, 99] и показывает 
наибольшую цифру числа */

void FindMaxNumber(int num)
{
    if (num >= 10 && num <= 99)
    {
        int dec = num / 10;
        int ed = num - (dec * 10);
        

        if (ed > dec)
        {
            System.Console.WriteLine($"{ed} -> max");
        }

        if (ed < dec) 
        {
            System.Console.WriteLine($"{dec} -> max");

        }

        if (ed == dec) 
        {
            System.Console.WriteLine("Numbers are equal");

        }
    }
    else
    {
        System.Console.WriteLine("Input number from 10 to 99");
    }

}

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

FindMaxNumber(num);
