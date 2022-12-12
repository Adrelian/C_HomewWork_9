// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void allNumber (int finish)
// {
//     int start = 1;
//     if (finish >= start)
//     {
//         allNumber(finish - 1);
//         Console.Write(finish + " ");
//     }
// }

// Console.Write("Введите первое число последовательности ");
// int start = Convert.ToInt32(Console.ReadLine());
// allNumber(start);

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumAllNumber(int start, int finish)
{
    if(start==finish) return start;

   if (start < finish)
   {
        start = start + sumAllNumber(start + 1, finish);
        return start;
   }
   else
   {
        start = start + sumAllNumber(start - 1, finish);
        return start;
   }
}

Console.Write("Введите первое число ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число ");
int finish = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sumAllNumber(start, finish));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29