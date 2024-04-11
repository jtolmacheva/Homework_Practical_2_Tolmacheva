/* Задача 2: Напишите программу, которая принимает 
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка 
2, 3 => 1
-5, 3 => 2
-3, -2 => 3
4, -2 => 4 */

void CoordinateQuarterNumber(int x, int y)
{
    int coordinate1 = 1;
    int coordinate2 = 2;
    int coordinate3 = 3;
    int coordinate4 = 4;

    if (x < 0 && y < 0)
    {
        System.Console.WriteLine($"{x}, {y}, => {coordinate3}");
    }

    if (x > 0 && y > 0)
    {
        System.Console.WriteLine($"{x}, {y}, => {coordinate1}");
    }

    if (x < 0 && y > 0)
    {
        System.Console.WriteLine($"{x}, {y}, => {coordinate2}");
    }

    if (x > 0 && y < 0)
    {
        System.Console.WriteLine($"{x}, {y}, => {coordinate4}");
    }


}

System.Console.WriteLine("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

CoordinateQuarterNumber(x, y);


