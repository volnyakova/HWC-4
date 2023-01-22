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
*/





//домашняя работа  5

//задайте массив заполненный случайными полопжительными трехзначными числами.
//напишите программу,которая покажет количество четных чисел в массиве.
/*
int[] Array = GetArray(10, 100, 1000);
Console.WriteLine($"[{String.Join(", ",Array)}]");
int sum = 0;
foreach (int el in Array)
{
    if(el % 2 == 0){
        sum += 1;
    }
}
Console.WriteLine($"Четных чисел в массиве {sum}");

int[] GetArray (int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue );
    }
    return res;
}
*/
//задайте одномерный массив,заполненный случайными числами. Найдите сумму элементов,стоящих на нечетных индексах.
int[] GetArray1 (int size)
{
    int[] Arr = new int[size];
    for(int i = 0; i < size; i++)
{
    Arr[i] = new Random().Next(-10, 11);
}
return Arr;
}

/*
int[] Array1 = GetArray1 (15);
Console.WriteLine($"[{String.Join(", ",Array1)}]");
int result = 0;
for(int i = 0; i < Array1.Length; i++)
{
   
    if(i % 2 != 0){
        result = Array1[i] + result;
    }
}


Console.WriteLine(result);
*/

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,второй  и предпоследний и т.д. Результат запишите в новый массив.
int[] Array2 = GetArray1(5);
Console.WriteLine($"[{String.Join(", ",Array2)}]");
int Length = Array2.Length;


int size = Length / 2 + Length % 2;
int[] NewArray2 = new int[size];
for(int i = 0;  i < size;  i++) 
    {
       
      
       NewArray2[i] = Array2[i] + Array2[Length - i - 1 ];
       if(i > size / 2){
        NewArray2[i] = Array2[i];

       }
    }
    
Console.WriteLine($"[{String.Join(", ",NewArray2)}]");
  
