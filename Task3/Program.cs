// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = new Random().Next (1,21);
System.Console.WriteLine( $"num={num}");

for(int a=1; a <= num; a++)
{
    System.Console.WriteLine(Math.Pow(a, 3));
}
