﻿/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив 
из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] newArray) 
{
    System.Console.Write("Задайте элементы массива:  ");
    for (int i = 0; i < newArray.Length; i++)
    {
        System.Console.Write($"[{i}]"); ;
        newArray[i] = Console.ReadLine()!;
    }

}

void PrintArray (int[] arrayToPrint)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i != arrayToPrint.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.WriteLine();
}

string[] FindShortElement(string[] shortElement)
{

    int count = 0;
    string element = String.Empty;
    for (int i = 0; i < shortElement.Length; i++)
    {
        if (element.Length < 4)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    count = 0;
    for (int i = 0; i < shortElement.Length; i++)
    {
       
        element = shortElement[i];
        if (element.Length <= 3)
        {
            resultArray[count] = element;
            count++;
        }
    }
    return resultArray;
}