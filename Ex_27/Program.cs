// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear(); //очистка терминала перед запуском
Console.WriteLine("Введите число, в котором мы будем находить сумму его цифр: ");
int number = Convert.ToInt32(Console.ReadLine());

//ввожу функцию
int SumCifr (int num)
{

//переводим наше число в строку:
int length=Convert.ToString(num).Length;
int peremen=0;
int sum_result=0;

for (int i=0; i<length; i++) //счетчик=0, пока меньше длины числа, +1
{
    peremen=num-num%10; //если 452, то peremen=452-2 //берем последнюю цифру числа
    sum_result=sum_result+(num-peremen); //0+(452-450)=2
    num=num/10; //теперь смотрим 45. И дальше: peremen=45-5=40
                //2+(45-40)=7. Дальше смотрим 4.
                //peremen = 4-4=0
                //результат = 7+ (4-0)=11
}
return sum_result;
}

int sumcifr=SumCifr(number);
Console.WriteLine($"Сумма цифр введенного числа {number} равна: {sumcifr}");
