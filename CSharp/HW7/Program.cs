//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// double [,] CreateRandom2DoubleArray(int rows, int cols ){
//    double[,] array = new double[rows, cols];
//    Random r = new Random();
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = r.NextDouble();
//     return array;
// }

// void Show2Array(double[,] array){
//     for(int i= 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"[{array[i,j]}]  ");
//         }
//     }
// }

// Console.Write("Input numb of m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double [,] array = CreateRandom2DoubleArray(m,n);
// Show2Array(array);

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// int [,] CreateRandom2Array(int rows, int cols, int min, int max){
//     int[,] array = new int[rows, cols];
//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < cols; j++)
//             array[i,j] = new Random().Next(min,max+1);
//     return array;
// }
// void Show2Array(int[,] array){
//     for(int i= 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"[{array[i,j]}]  ");
//         }
//     }
// }

// void ElementPosition (int elementNumber, int [,] array){
// if(elementNumber > (array.GetLength(0) * array.GetLength(1))) 
// Console.WriteLine("Your element is not defined");
// else {
// int i = 0;
//     while(elementNumber > i*array.GetLength(1)) ++i;
//         int j =  elementNumber - (i-1)*array.GetLength(1);
//     Console.WriteLine($"Your element is: {array[(i-1),(j-1)]}");
// }
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the element number: ");
// int eN = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2Array(rows,cols, min,max);
// Show2Array(array);
// ElementPosition(eN, array);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Можно было через void решить и просто выводить цифры, но через массив интереснее )
int [,] CreateRandom2Array(int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            array[i,j] = new Random().Next(min,max+1);
    return array;
}
void Show2Array(int[,] array){
    for(int i= 0; i<array.GetLength(0); i++){
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"[{array[i,j]}]  ");
        }
    }
}

void ShowArray(double[] array){
    for(int i= 0; i<array.GetLength(0); i++){
        Console.Write($" {array[i]};");
    }
}

double [] ArithMean(int[,] array){
    double sum = 0;
    double [] arr = new double [array.GetLength(0)];
    for(int i= 0; i<array.GetLength(0); i++){
        for(int j= 0; j<array.GetLength(1); j++){
        sum += array[j,i];
    }
        arr[i] = sum/array.GetLength(1);
        sum = 0;
  }
return arr;
}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of columns: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2Array(rows,cols, min,max);
double [] arr = ArithMean(array);

Show2Array(array);
ArithMean(array);
Console.WriteLine();
Console.Write("The arithmetic mean of the elements in each column: ");
ShowArray(arr);

