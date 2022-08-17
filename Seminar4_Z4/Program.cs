// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке

Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());

int[] array_new = new int[n]; //мы создаем массив на n элементов

void FillArray(int[] array, int length)
{
   
    int i = 0;
    while (i<length)
    {
    array[i]=new Random().Next(0, 2);
    
    Console.Write($"{array[i]}, ");
    i++;
    }

//Console.WriteLine();
}

Console.WriteLine($"Массив из {n} элементов, заполненный 0 и 1: ");
Console.Write("[");
FillArray(array_new, n);
Console.Write("]");
