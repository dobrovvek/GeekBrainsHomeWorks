//Задача 25 Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

// int Step(int a, int b) {
//     int c = a; 
//     for ( int i = 1; i < b ; i++ ){
//         c *= a;
//     }
//     return c;
// }

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите в какую степень возвести Ваше число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b < 0) Console.WriteLine ("Условие ввода не соблюдено ");

// Console.WriteLine(Step(a,b));


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// int Number(int num){

// int result=0;

//     for (int i = 0; num != 0 ;i++ ){
//          result += num%10;
//          num /= 10;
//     }
//          return result;
// }
// Console.WriteLine("Enter number : ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Number(n));


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
//Вариант 1 
/*
int [] array = new int[8];

for (int i = 0; i < 8; i++ ){
    Console.Write(" Введите " + (i+1) + " элемент массива : ");
    array[i] = Convert.ToInt32(Console.ReadLine()); 
}
void ShowArray(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i <arr.Length; i++){
        Console.Write(arr[i]+ " ");
    }
    Console.Write("]");
}
    ShowArray(array);
//для себя //Console.WriteLine($"[{array[0]}] [{array[1]}] [{array[2]}] [{array[3]}] [{array[4]}] [{array[5]}] [{array[6]}] [{array[7]}]");
 */
//Вариант 2 с задаваемым числом размера  

int[] Array(int len){ 
    int[] ar = new int[len]; 
    for(int i = 0; i < len; i++){
    Console.Write($" Enter array element number {(i+1)} : ");
    ar[i] = Convert.ToInt32(Console.ReadLine());
    }
    return ar;
} 
void ShowArray(int[] arr){
    Console.Write("[ ");
    for (int i = 0; i <arr.Length; i++){
        Console.Write(arr[i]+ " ");
    }
    Console.Write("]");
}
Console.WriteLine("Enter array length : ");
int len = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(len));





