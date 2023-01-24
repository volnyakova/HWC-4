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



/*

//домашняя работа  5

//задайте массив заполненный случайными полопжительными трехзначными числами.
//напишите программу,которая покажет количество четных чисел в массиве.

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
*/





// ДОМАШНЯЯ РАБОТА 6

/*
// Пользователь вводит с клавиатуры М чисел.
// Посчитайте,сколько чисел строго больше 0 ввел пользователь.
Console.WriteLine("Введите числа через пробел: ");
string M = (Console.ReadLine()!);
string[] N = M.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries );
foreach(string el in N)
{
    Console.Write($"[{String.Join(",",(el))}]");
}
int sum = 0;

for(int i = 0; i <= N.Length - 1; i++)
{
    if(Convert.ToInt32(Convert.ToString(N[i])) > 0) sum = sum+1;
    
}
Console.WriteLine();
Console.WriteLine($"Цифр больше 0 : {sum}");

*/

// Написать программу,которая на вход принимает массив из любого колличества
// элементо(не менее 6) в промежутке от 0 до 100,а на выходе выводит этот же
//массив, но отсортированный по возрастанию(от меньшего числа к большему)
int[] array4 = GetArray4(6, 0, 100);
Console.WriteLine($"[{String.Join(",",array4)}]");
int[] newArray4 = GetReversArray(array4);
Console.WriteLine($"[{String.Join(",",newArray4)}]");
  
    
//-----------Метод--------------
int[] GetArray4 (int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//----------Метод---------------
int[] GetReversArray (int[] array)
{
    
    for(int i = 0; i < array.Length/2; i++)
    {
     
    int k = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = k;
        
    }
    return array;
}
