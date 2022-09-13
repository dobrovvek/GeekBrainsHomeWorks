// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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
//             Console.Write(array[i,j]+ " ");
//         }
//     }
// }

// int [,] MinMax(int [,] array){
//     int temp;
//     for(int i= 0; i<array.GetLength(0); i++){
//         Console.WriteLine();
//         for(int j = 0; j < array.GetLength(1); j++){
//             for(int a = j+1; a < array.GetLength(1); a++ ){
            
//             if(array[i,j] < array[i,a]) {
//                 temp = array[i,j];
//                 array[i,j] = array[i,a];
//                 array[i,a] = temp;
//             }
//         }
//     }    
// }
//     return array;
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int [,] array = CreateRandom2Array(rows,cols, min,max);
// Show2Array(array);
// Console.WriteLine();
// int [,] bArray = MinMax(array);
// Show2Array(bArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
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
            Console.Write(array[i,j]+ " ");
        }
    }
}

void MinRow (int [,] array){
    int sum = 0, 
        min=0,
        a = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++){
          sum += array[i,j]; 
            }
            //Console.Write($"sum line {i+1} is {sum}; ");
            if (i == 0) min = sum;
            else if (sum < min) {
                min = sum;
                a = i;
                } 
                 sum = 0;
        }
      //Console.WriteLine();  
Console.WriteLine($"minimal sum in line - {a+1}");

}

Console.Write("Input numb of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of max: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreateRandom2Array(rows,cols, min,max);
Show2Array(array);
Console.WriteLine();
if(array.GetLength(0) == array.GetLength(1)) Console.WriteLine("It is squared matrix");
else MinRow(array); 
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int [,] Spiralka(int a){
    int[,] array = new int[4,4];
    int i = 0,
        j = 0;
        for(j = 0; j < array.GetLength(1); j++){
            array[i,j] = a + 1 ;
            a = array[i,j];
        }
    j = 3;
        for(i = 1; i < array.GetLength(0); i++){
            array[i,j] = a + 1 ;
            a = array[i,j];
        }
    i = 3;
        for(j = 2; j !=-1 ; j--){
            array[i,j] = a + 1 ;
            a = array[i,j];
        }
    j = 0;
        for(i = 2; i != 0; i--){
            array[i,j] = a + 1 ;
            a = array[i,j];
        }
    i = 1;
        for(j = 1; j < array.GetLength(1)-1 ; j++){
            array[i,j] = a + 1 ;
            a = array[i,j];
        }
    j = 2;
            i=2;
            array[i,j] = a + 1 ;
            a = array[i,j];
    i = 2;
            j=1;
            array[i,j] = a + 1 ;
            a = array[i,j];
        
        return array;
}

void Show2Array(int[,] array){
    for(int i= 0; i<array.GetLength(0); i++){
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write("["+array[i,j] + "] ");
        }
    }
}
Console.Write("Input start number: ");
int a = Convert.ToInt32(Console.ReadLine())-1;

Show2Array(Spiralka(a));


