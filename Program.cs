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

int input(string dot)
{
    Console.WriteLine($"Введите точку {dot}:");

    return Convert.ToInt32(Console.ReadLine());
}

int x1 = input("x1");

int y1 = input("y1");

int z1 = input("z1");;

int x2 = input("x2");;

int y2 = input("y2");;

int z2 = input("z2");;

Console.WriteLine($"Расстояние между точками равно {distance(x1, y1, z1, x2, y2, z2)}");

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