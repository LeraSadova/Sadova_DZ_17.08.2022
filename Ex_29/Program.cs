// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("ВВЕДИ ЧИСЛО ЭЛЕМЕНТОВ МАССИВА: ");
Console.WriteLine("ps: лучше введите небольшое число, чтобы не заполнять много цифр ;)");

int n=Convert.ToInt32(Console.ReadLine());
int[] array_new = new int[n]; //мы создаем массив на n элементов

int i=0;
while (i<n)
{
    Console.WriteLine($"Введите {i+1}-й элемент массива"); //вводим элементы массива с клавиатуры
    array_new[i]=Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine();
    i++;
}

//выводим массив на экран:
for (i = 0; i < n; i = i + 1)
Console.Write($"[{array_new[i]}]");
//Console.Write($"{array_new[i]}, ");





