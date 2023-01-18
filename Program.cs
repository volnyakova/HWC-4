/*
//Напишите программу,которая принимает на вход число и выдает сумму цифр в числе.
Console.WriteLine("Введите число: ");
int A1 = int.Parse(Console.ReadLine()!);
Console.Write($"Ссумма чисел в числе {A1},равна {GetSum(A1)}");

int GetSum (int A1)
{
    int Sum = 0;
    while (A1 > 0)
    {
        Sum += A1 % 10;
        A1 = A1 / 10;
    }
    return Sum;

}
*/

/*
//Напишите цикл, который принимает на вход на числа(А и В) и возводит число А в натуральную степень В.
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write($"Число {A} в степени {B}, рано {GetPower(A, B)}");

long GetPower (int A, int B)
{
    long Power = 1;
    int i = 1;
    while (i <= B)
    {
        i++;
        Power = Power * A;
    }
    return Power;
}
*/

//Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
int[] Array = GetArray(8);
Console.Write($"[{String.Join(";",Array)}]");


int[] GetArray (int size)
{
    int[] Array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Array[i] = new Random().Next();
    }
    return Array;
}
