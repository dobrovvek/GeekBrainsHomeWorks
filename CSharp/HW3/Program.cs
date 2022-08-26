// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// void palidrom(int pal) {
//     int a = pal % 10;
//     int b = (pal % 100 - a) / 10;
//     int c = (pal % 1000 - b * 10 - a) / 100;
//     int d = (pal % 10000 - c * 100 - b * 10 -a) / 1000;
//     int e = (pal - d * 1000 - c * 100 - d * 10 - a) / 10000;
//       if( a == e && b == d){
//       Console.WriteLine("число является палиндромом");
//       }
//       else {
//         Console.WriteLine("число не является палиндромом");
//       }  
// }
// Console.WriteLine("Enter Number: ");
// int pal = Convert.ToInt32(Console.ReadLine());
// while (pal<9999 || pal > 99999) {
//     Console.WriteLine("This is not a five-digit number! Enter a number:  ");
//     pal = Convert.ToInt32(Console.ReadLine());
// }
// palidrom(pal); 


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

// double average(int x1, int y1, int z1, int x2, int y2, int z2){
// double num = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
// return num; 
// }
// Console.WriteLine("Enter x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The distance between the points is equal to: " + average(x1, y1, z1, x2, y2,z2));


// Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

void cube (int cu) {
    int i = 0;
    while(cu > i){
    i++; 
Console.Write( i * i * i + " ");
    }
}

 Console.WriteLine("Введите положительное число не равное нулю : ");
int cu = Convert.ToInt32(Console.ReadLine());
if (cu <= 0) Console.WriteLine("Условие ввода не соблюдено");
else cube (cu);
