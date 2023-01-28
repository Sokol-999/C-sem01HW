//  Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число, чтобы получить все четные числа от 1 до Вашего: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
System.Console.WriteLine("Последовательность: ");
while (i <= N)
{
    if (i % 2 == 0)
    {
        System.Console.WriteLine(i);
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}
