/* Задача 4: Напишите программу, которая на вход 
принимает натуральное число N, а на выходе 
показывает его цифры через запятую 
568 => 5,6,8
8 => 8
9542 => 9,5,4,2 */

void NumberDot(int num)
{
    if (num < 10)
    {
        System.Console.WriteLine($"{num} => {num}");
    }

    if (num >= 10 && num <= 99)
    {
        int ed = num % 10;
        int dec = num / 10;
        System.Console.WriteLine($"{dec}, {ed}");

    }

    if (num >= 100 && num <= 999)
    {
        int ed = num % 10;
        int dec = num / 10 % 10;
        int hund = num / 100;
        System.Console.WriteLine($"{hund}, {dec}, {ed}");

    }

     if (num >= 1000 && num <= 9999)
    {
        int ed = num % 10;
        int dec = num / 10 % 10;
        int hund = num / 100 % 10;
        int thousands = num / 1000;
        System.Console.WriteLine($"{thousands}, {hund}, {dec}, {ed}");

    }



}

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

NumberDot(num);
