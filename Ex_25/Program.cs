// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear(); //очистка терминала перед запуском

int Vozvedenie_V_Stepen(int number, int number_stepen)
{
  int result_v_step = 1; //для умножения приравниваем к 1

  for(int i=1; i <= number_stepen; i++) //(инициализатор; условие выполнения; выражение итерации)
  { //возведем 2 в степень 3
    result_v_step = result_v_step * number; //1*2=2, результат=2. +1. 2<=3? - да. наш результат 2*2=4.
    //результат =4. счетчик еще +1=3 3<=3? - да, тогда наш результат 4 снова умножаем на 2=6. i++ и все. Цикл закончен.
    //выводим результат. 
  }
       return result_v_step; //выводим результат возведения в степень
}

  Console.WriteLine("Введите число, которое будем возводить в степень: ");
  int number1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine($"Введите степень, в которую будем возводить число {number1}:");
  int stepen = Convert.ToInt32(Console.ReadLine());

  int vozv_v_stepen = Vozvedenie_V_Stepen(number1, stepen);
  Console.WriteLine($"Число {number1} в степени {stepen} равно *{vozv_v_stepen}*");