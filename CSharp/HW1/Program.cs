// Задача 2 = (1)
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
/*
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


*/
//Задача 6 = (3)
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
int num;
Console.Write("напечатайте целое, проверяемое Вами на чётность число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
Console.Write("чётное");
}
else {
    Console.Write("нечётное");
}


*/ 
// Задача 8 = (4)
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

int num;
Console.Write("напечатайте любое целое, положительное число:  ");
num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <= num) {
    Console.Write(current + " ");
    current = current + 2;
}

