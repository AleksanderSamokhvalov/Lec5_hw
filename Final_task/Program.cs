﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["привет", "2", "мир", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", " информатика"] -> ["-2"]
// ["Россия", "Дания", "Казань"] -> []

string[] array = { "hello_kity", "221", "task", "geek", "0_0", "(*)", "Go",
"88", "telegrapf", "cheek", "KHV", "Moscow", "cool", "..." };
int count = ArrayCheck(array);
string[] resultArray = FillResultArray(array, count);
int ArrayCheck(string[] array)
{
 int count = 0;
 for (int i = 0; i < array.Length; i++)
    {
 if (array[i].Length <= 3) count++;
    }
 return count;
 }
string[] FillResultArray(string[] array, int count)
{
 string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
 if (array[i].Length <= 3)
        {
 result[result.Length - count] = array[i];
 count--;
        }
    }
 return result;
}
void PrintArray(string[] array)
{
 Console.Write("[");
 for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]}, ");
 Console.Write($"{array[array.Length - 1]}]");
}
PrintArray(resultArray);