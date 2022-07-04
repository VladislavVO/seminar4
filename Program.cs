/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
int sumOfDigits(int number1)
{
int digitCount = (int)Math.Log10(number1);
    int sum = 0;
    for (int i=1; i<=digitCount+1; i++)
    {
        sum = sum + number1 % 10;
        number1 = number1 / 10;
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


int y = 5;
int[] array = new int[y];
Random rand = new Random();

for (int i = 0; i < y; i++)
{
     array[i] = rand.Next(1, 21);
    Console.Write(array[i] + " ");

}

