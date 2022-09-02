//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size) {
    int[] array = new int [size];
    for(int i=0; i<size; i++){
        array[i] =new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array){
    for(int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int Chet (int[] array){
    int count = 0;
    for(int i=0; i<array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size); 
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"the number of three-digit even numbers is equal to - {Chet(array)} ");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int min, int max) {
    int[] array = new int [size];
    for(int i=0; i<size; i++){
        array[i] =new Random().Next(min, max);
    }
    return array;
}

void ShowArray(int[] array){
    for(int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

int NechetSum(int[] array){
    int count = 0;
    for(int i=1; i<array.Length; i += 2){
        count+=array[i];
    }
    return count;
}

Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(size, min, max); 

ShowArray(array);
Console.WriteLine();
Console.WriteLine($"Sum numbers is {NechetSum(array)}");
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] DoubRandomArray(int size) {
    double[] array = new double [size];
    for(int i=0; i<size; i++){
        array[i] = new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array){
    for(int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}

double MaxMin(double[] array){
    double max = array[0];
    double min = array[0];

    for(int i=0; i<array.Length; i++){
        if(array[i] > max ) max = array[i];
        if(array[i] < min ) min = array[i];
    }
        return max - min;
}
Console.WriteLine("input size: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = DoubRandomArray(size); 
ShowArray(array);
Console.WriteLine();
Console.WriteLine($"max - min = {MaxMin(array)}");
