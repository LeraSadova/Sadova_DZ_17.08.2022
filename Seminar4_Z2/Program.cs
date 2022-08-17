//Console.WriteLine("Hello, World!");
//Задача 26: Напишите программу, которая принимает на вход число
//и выдает количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89123 -> 5

Console.WriteLine("Введите число N: ");
int n= Convert.ToInt32(Console.ReadLine());
int Count_Number (int num)
{
    int count=0;//наш счетчик. присваиваем 1
    while (num>0) //пока наше число больше 0 - делаем цикл
    {
        num/=10; //делится на 10
        count++; // если да, то +1. проверяем полученное число больше ли оно 10?
    }
    return count; // если уже не больше 10, то возвращаем count
}
Console.WriteLine(Count_Number(n));

