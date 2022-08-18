// Задача 2/2 = (1)
//Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

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

