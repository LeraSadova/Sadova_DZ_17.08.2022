// Задача 24
// Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до А
// 7 --> 28
// 4 --> 10
// 8 --> 36
//Но мы напишем с методом. для 3х чисел - для А, В, С.
Console.Clear();

void SumOneToA (int a) //принимает число а, но ничего не возвращает
{
    int sum = 0;
    for (int i=1; i<=a; i++)
    {
        sum=sum+i;
    }
    Console.WriteLine($"сумма числе от 1 до {a} = {sum}");
}

Console.WriteLine("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
SumOneToA (num1);

Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumOneToA (num2);

Console.WriteLine("Введите число C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
SumOneToA (num3);