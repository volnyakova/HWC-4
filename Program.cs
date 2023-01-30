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



// Написать программу,которая на вход принимает массив из любого колличества
// элементо(не менее 6) в промежутке от 0 до 100,а на выходе выводит этот же
//массив, но отсортированный по возрастанию(от меньшего числа к большему)
int[] array4 = GetArray4(6, 0, 100);
Console.WriteLine($"[{String.Join(",",array4)}]");
int[] newArray = GetNewArray(array4);
Console.WriteLine($"[{String.Join(",",newArray)}]");

//--------------метод----------
int[] GetNewArray(int[] array)
{
   int k;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            k = array[i];
            array[i] = array[j];
            array[j] = k;
        }
    }
}
return array;
 
    }  
    
//-----------Метод--------------
int[] GetArray4 (int size, int minValue, int maxValue){
int[] res = new int[size];
for(int i = 0; i < size; i++)
{
        res[i] = new Random().Next(minValue, maxValue + 1);
        
}
    
        return res;
}
*/






//----ДОМАШНЯЯ РАБОТА 7------------------
// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, columns, 0 ,10);
PrintArray(array);



//--------metod-------------
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j <n; j++){
            result[i,j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(),1) ;
            
        }
    }
    return result;
}

void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write($"{array[i,j] + "\t"}");
        }
        Console.WriteLine();
    }
}



// Напишите программу, котораая на вход принимает число, и проверяет есть ли такое число в двумерном массиве,
// а так же возвращает сообщение о том, что оно найдено или же
// указание, что такого элемента нет.
Console.WriteLine(" Введите число: ");
int k = int.Parse (Console.ReadLine()!);
int m = 5;
int n = 5;
int[,] array1 = GetArray1(m, n, 0, 100 );
if(GetNum(array1))
{
    Console.WriteLine("Элемент найден!");   
}
else Console.WriteLine("Элемент не найден!");   



int[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j <n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{result[i, j]}  ");
           
        }
        Console.WriteLine();
    }
    
    return result;
}
 

bool GetNum(int[,] array )
{
  for(int i = 0; i < array1.GetLength(0); i++)
  {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            if( k == array1[i,j]) 
            { 
                return true;
            } 
                      
        } 

  }

   return false;  
}  


// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
int m1 = 5;
int n1 = 5;
int[,] array2 = GetArray1(m1, n1, 0, 100 );
GetArrayNew(array2);
         
    

/*
int[,] GetArray1(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j <n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{result[i, j]}  ");
           
        }
        Console.WriteLine();
    }
    
    return result;
}
*/

void GetArrayNew(int[,] array)
{  
    int rows = array2.GetUpperBound(0) + 1; 
    int columns = array2.Length / rows;  
    for(int j = 0; j < columns; j++)
    {
        double sum = 0;
        for(int i = 0; i < rows; i++)
        {
            sum += array2[i,j];
        }
        Console.WriteLine($" {j} = {Math.Round(sum / rows,1)}");

    }
}

        
    
