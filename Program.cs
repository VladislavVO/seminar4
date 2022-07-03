/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int sumOfDigits(int number1)
{
int digitCount = (int)Math.Log10(number1) + 1;
int digit = digitCount;
int sum = 0;
for (int i=1; i<=digitCount; i++)
    {
    int StepenDeleniya = Convert.ToInt32(Math.Pow(10, digit-1));
    sum = sum + number1 / StepenDeleniya;
    number1 = number1 % StepenDeleniya;
    digit = digit - 1;
    }
return sum;
}
Console.Write("Input number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Sum of digits is " + sumOfDigits(number1));
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
