﻿// Задача 2 = (1)
//Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
/*
int num1;
Console.Write("напечатайте целое число, которое хотите сравнить: ");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;
Console.Write("напечатайте целое число, с которым хотите сравнить ранее напечатанное: ");
num2 = Convert.ToInt32(Console.ReadLine());


if (num1 > num2) {
    Console.Write(num1 + " больше чем " + num2 );
}
else {
    Console.Write(num2 + " больше чем " + num1);
}


*/
//Задача 4 = (2)
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int num1;
Console.Write("напечатайте первое целое число, которое хотите сравнить: ");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;
Console.Write("напечатайте второе целое число, которое хотите сравнить: ");
num2 = Convert.ToInt32(Console.ReadLine());

int num3;
Console.Write("напечатайте третье целое число, которое хотите сравнить: ");
num3 = Convert.ToInt32(Console.ReadLine());

int maximum;


if (num1 > num2) {
    maximum = num1;
}
else {
   maximum = num2;
}
if (num3 > maximum) {
   Console.WriteLine("Наибольшее из трёх чисел - " + num3) ;
}
else {
 Console.WriteLine("Наибольшее из трёх чисел - " + maximum) ;
}