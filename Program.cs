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

/*РЕШЕНИЕ1. ПОЛЬЗОВАТЕЛЬ ВЫБИРАЕТ РАЗМЕР МАССИВА, МИН И МАКС ЭЛЕМЕНТЫ*/
/*
int[] Array(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);  
    }
   return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = Array(size, min, max);
ShowArray(MyArray);
*/


/* РЕШЕНИЕ2. ПРОГРАММА ВЫДАЕТ МАССИВ ИЗ 8МИ ЭЛЕМЕНТОВ ОТ 0 ДО 100 В ДВЕ СТРОКИ: 5 И 3 */

/*
int[] Array(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min,max+1);  
    }
   return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < 5; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();  

    for (int i = 5; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine(); 
}

int[] MyArray = Array(8, 0, 100);
ShowArray(MyArray);

*/