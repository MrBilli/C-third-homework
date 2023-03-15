// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.

/*

bool checkPalindrome(int num)
{
    if(num / 10000 == num % 10 && num / 1000 % 10 == (num % 100 - num % 10) / 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите 5-ти значное целое число:");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} является полиндромом - {checkPalindrome(number)}");

*/

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

/*

double distance( int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2 )), 2);
}

Console.WriteLine("Введите x1:");

int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");

int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1:");

int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2");

int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2");

int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2");

int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(distance(x1, y1, z1, x2, y2, z2));

*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*

void cubesTable(int n)
{
    int count = 1;
    while(count <= n)
    {
        Console.WriteLine($"Куб числа {count} равен {count*count*count}");
        count++;
    }
}

Console.WriteLine("Введите число, до которого включительно нужно показать таблицу кубов:");

int number = Convert.ToInt32(Console.ReadLine());

cubesTable(number);

*/