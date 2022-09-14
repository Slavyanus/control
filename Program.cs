// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 
//символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

using System;
 
string[] array =
{
    "a",
    "bb",
    "ccc",
    "dddd",
    "eeeee",
    "z"
};

var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
 
