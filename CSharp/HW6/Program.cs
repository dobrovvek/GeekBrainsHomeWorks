//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Fin(int size){
    int[] arr = new int [size];
    int count = 0;
for(int i = 0; i < size; i++){
    Console.Write($"Ввведите число номер {i+1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i] > 0){
        count++;
        }
    }
    return (count); 
}
Console.Write("Ввведите колличество вводимых чисел M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Колличество чисел больше 0: " + Fin(n));
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//k1*x + b1 = k2*x + b2 ; k1*x-k2*x = b2 - b1 ; x=(b2-b1)/(k1-k2)
void Tochca(double c, double a, double c2 ,double a2){
double x; double y; 
x = (c2 - c) / (a - a2);

y = (a*x+c);
Console.WriteLine($"({x};{y})");
}
Console.Write("Ввведите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввведите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввведите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
 
Tochca(b1, k1, b2, k2);
