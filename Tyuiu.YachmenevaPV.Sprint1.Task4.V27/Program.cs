﻿using Tyuiu.YachmenevaPV.Sprint1.Task4.V27.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Class Math.                                                       *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #27                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* вычисляет результат по формулеи печатает его на экране.                 *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int x, y;

    Console.WriteLine("Введите значение Х:");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение Y:");
    y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("1 + sinPix / (x - sqrt|y|) = " + ds.Calculate(x, y));

    Console.ReadKey();

}