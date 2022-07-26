// Домашнее задание к семинару №9
//
// Задача 64: Задайте значение N. 
// Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4

Console.Write("Введите целое многозначное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {numberN}: " + CheckNumber(numberN,1));

int CheckNumber (int number, int k_digit)
{
   if (number/10 != 0)
   {
      k_digit = CheckNumber(number/10, k_digit+1);
   }
   return k_digit;
}


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел в промежутке от {M} до {N}: " + SummaNumbers(M, N));

int SummaNumbers(int num1, int num2)
{
   if (num1 < num2) 
     return num1 + SummaNumbers(num1+1, num2);
 
   return num1;
}
