/* //Задача 10: 
//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
void cutNumber(){ 
    int num = new Random().Next(100,1000); 
     Console.WriteLine("Number- " + num);
     int dec = num % 100;
     int ed = num % 10;
     int result = (dec - ed) / 10;
     Console.WriteLine("Cut number is- " + result);
}
cutNumber(); 


/* //Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
 /* int fun(int num){
    if (num > 100){
    string stroka = Convert.ToString(num);
    num = stroka[2] - '0';
    return num; 
    } 
    if(num == 100){
        num = 0;
        return num; 
    }
    else {
        return -1;
    }
 }

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = fun(num);
if(result == -1){
Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine("Третья цифра - " + result);
}

*/
/* //Задача 13 способ решенеие массивом (для себя): 
int num; 
Console.WriteLine("enter number - ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 99){
    string stroka = Convert.ToString(num);
    char [] ar = stroka.ToCharArray();
    Console.WriteLine(ar[2]);
    }
    else {
        Console.WriteLine("третьей цифры нет");
    } 

*/
// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

 /*void week(int num){
    if (num == 6 || num == 7){
    Console.WriteLine("Выходной");
    }
    else{
         if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5){
         Console.WriteLine("Будни"); 
         }  
         else {
         Console.WriteLine("Не является днём недели"); 
         }
     }
 }
//while(true)
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
week(num);
//} */

/*int fun(int num){
if (num > 99){
string stroka = Convert.ToString(num);
num = stroka[2] - '0';
return num;
}
else {
return -1;
}
}
Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = fun(num);
if(result == -1){
Console.WriteLine("Третьей цифры нет");
}
else{
/*int fun(int num){
    if (num > 99){
    string stroka = Convert.ToString(num);
    num = stroka[2] - '0';
    return num; 
    } 

    else {
        return -1;
    }
 
}

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = fun(num);
if(result == -1){
Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine("Третья цифра - " + result);
}

void week(int num){
if (num > 5 || num < 8){
Console.WriteLine("Выходной");
}
else{
if (num > 0 && num < 6){
Console.WriteLine("Будни");
}
else {
Console.WriteLine("Не является днём недели");
}
}
} */
