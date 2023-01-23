System.Console.WriteLine("Введите число и узнайте четное или нечетное: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ответ");
if (numberA % 2 == 0)
{
System.Console.WriteLine("Четное");
}
else
System.Console.WriteLine("Нечетное");