//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// или в обратной последовательости
/*
int ReadData(string line)
{
Console.Write(line);
int num = int.Parse(Console.ReadLine()??"1");
return num;
}

void PrintDataStr(string prefix, string num)
{
    Console.WriteLine(prefix+num);
}

string RecursMToN(int m, int n)
{
    if (m <=n) 
        {
        if(m >= n) 
        {
            return $"{n}";
        }
        else
        {
        string outLine = RecursMToN(m,n-1) + "," + n;

            return outLine;
        }
    } 
    else 
        {
        if(m <=n) 
        {
            return $"{m}";
        }
        else
        {
            string outLine = m + "," + RecursMToN(m-1,n);
            return outLine;
        }
    } 
}


int m = ReadData("Enter natural positive number M: ");
int n = ReadData("Enter natural positive number N: ");

string outLine1 = RecursMToN(m, n);
PrintDataStr("Natural numbers from M to N : ", outLine1);
*/

// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N 
// или в обратной последовательости
/*
int ReadData(string line)
{
Console.Write(line);
int num = int.Parse(Console.ReadLine()??"1");
return num;
}

void PrintDataInt(string prefix, int num){
    Console.WriteLine(prefix+num);
}

int SumMToN (int m, int n)
{

    if(n >= m)
    {
        if( m == n ) return n;
        return n + SumMToN(m,n-1);
    }
    else
    {
        if( m == n ) return m;
        return m + SumMToN(m-1,n); 
    }
}

int m = ReadData("Enter natural positive number M: ");
int n = ReadData("Enter natural positive number N: ");

int outLine2 = SumMToN(m, n);
PrintDataInt("Sum natural numbers from M to N : ", outLine2);
*/

//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadData(string line)
{
Console.Write(line);
int num = int.Parse(Console.ReadLine()??"1");
return num;
}

void PrintDataInt(string prefix, int num){
    Console.WriteLine(prefix+num);
}

int Akerman(int n, int m)
{
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
}

int m = ReadData("Enter natural positive number M: ");
int n = ReadData("Enter natural positive number N: ");

int outLine2 = Akerman(m, n);
PrintDataInt("Akerman: ", outLine2);