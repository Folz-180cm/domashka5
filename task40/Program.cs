﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1<num2+num3 && num2<num1+num3 && num3<num1+num2)
{
    Console.WriteLine("Такой треугольник может существоать");
}
else
{
    Console.WriteLine("Такого треугольника не может существовать");
}

