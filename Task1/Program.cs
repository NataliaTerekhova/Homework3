// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine ());
int reverse =0;
int number2 =number;

 while (number2>0) 
 {
    reverse *= 10;
    reverse += number2 % 10;
    number2 /= 10;
 }
 
        if (reverse==number)
        {
            System.Console.WriteLine( $"{number} равно {reverse} => это палиндром");
        }
        else 
        {
            System.Console.WriteLine( $"{number} не равно {reverse} => это не палиндром");
        }
        
