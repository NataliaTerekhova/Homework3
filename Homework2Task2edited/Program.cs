//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{ 
   string str = number.ToString();
   System.Console.WriteLine(str[2]);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}