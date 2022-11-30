/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int N = int.Parse(Console.ReadLine());
int[] myArr = new int [N];

getCubesOfNumbers(myArr, N);

PrintArray(myArr);

void getCubesOfNumbers(int[] myArr, int N)
{
    for (int i = 1; i <= N; i++)
    {
        myArr[i - 1] = i * i * i;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}