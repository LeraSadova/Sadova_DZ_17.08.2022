
// Задача 28. Напишите программу, которая принимает на вход число N 
// и выдает произведение чисел от 1 до N 
// 4 -> 24
// 5 -> 120
Console.Clear();

void ProizvOneToA (int a) //принимает число а, но ничего не возвращает
{
    int proizv = 1;
    for (int i=1; i<=a; i++)
    {
        proizv=proizv*i;
    }
    Console.WriteLine($"произведение чисел от 1 до {a} = {proizv}");
}

Console.WriteLine("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
ProizvOneToA (num1);

Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ProizvOneToA (num2);

Console.WriteLine("Введите число C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
ProizvOneToA (num3);