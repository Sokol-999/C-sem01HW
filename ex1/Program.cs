Console.WriteLine("Введите два числа и большее Вы увидете на экране");
System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Большее число: ");
if (numberA > numberB)
{ 
    System.Console.WriteLine(numberA);
}
else
{
    System.Console.WriteLine(numberB);
}