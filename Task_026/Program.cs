﻿// Задача 26:
// Напишите программу, которая
// принимает на вход число 
// и выдает количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int countNumber = CountNumber(number);
Console.WriteLine($"{number} -> {countNumber}");

int CountNumber(int num)
{
  if (num < 0) num = num * -1; // включая отрицательное число
  int count = 1; // = 0; включая ноль поставить 1 и 9
  while (num > 9) // > 0)
  {
    num = num / 10;
    count++;
  }
  return count;
}
