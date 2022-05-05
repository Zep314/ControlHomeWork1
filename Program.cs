﻿// Итоговая проверочная работа.
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


using System;


// void MyPrintArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

static void MyPrintArray(string[] localArray)
{
    Console.Write("[");
    for (int i =0; i < localArray.Length; i++)
    {
        Console.Write($"\"{localArray[i]}\"");
        if (i != localArray.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Итоговая проверочная работа.");
Console.Write("Введите количество строк исходного массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] iArray = new string [n];
int m = 0;
for (int i=0; i<iArray.Length; i++)
{
    Console.Write($"Введите {i+1}-ю строку: ");
    iArray[i] = Console.ReadLine();
    if (iArray[i].Length<4)
    {
        m++;
    }
}
Console.WriteLine("Исходный массив: ");
MyPrintArray(iArray);

string [] rArray = new string [m];
int k = 0;
for(int i=0; i<iArray.Length; i++)
{
    if (iArray[i].Length<4)
    {
        rArray[k] = iArray[i];
        k++;
    }
}

Console.WriteLine("Результирующий массив: ");
MyPrintArray(rArray);
