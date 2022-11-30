/*Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}

int originNumber = number;
int rev = 0;

while (number > 0)
{
    int dig = number % 10;
    rev = rev * 10 + dig;
    number = number / 10;
}
  if (originNumber == rev)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
    {
        Console.WriteLine("Это не палиндром!");
    }