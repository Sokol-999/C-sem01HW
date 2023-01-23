Console.WriteLine("Введите два числа и большее Вы увидете на экране");
System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Большее число: ");

if (numberA > numberB)
{
    if (numberA>numberC)
    {
        System.Console.WriteLine(numberA);
    }
    else
    {
        System.Console.WriteLine(numberC);
    }
}
else
{
    if (numberB > numberC)
    {
        System.Console.WriteLine(numberB);
    }
    else
    {
        System.Console.WriteLine(numberC);
    }
}
