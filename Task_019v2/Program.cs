﻿// Задача 19v2. 
// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num < 0 ? -num : num;
int Reverse(int number)
{
  int reversedNum = 0;
  while (number > 0)
  {
    reversedNum = reversedNum * 10 + number % 10;
    number = number / 10;
  }
  return reversedNum;
}
if (num == Reverse(num)) Console.WriteLine($"Число {num} является палиндроном.");
else Console.WriteLine($"Число {num} не является палиндроном.");
