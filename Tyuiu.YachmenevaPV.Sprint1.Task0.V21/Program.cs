using Tyuiu.YachmenevaPV.Sprint1.Task0.V21.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #21                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программуБ которая вычисляет выражение 3 * 4 + 10 / 2          *");
    Console.WriteLine("* и печатает результат на экране.                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate());
    Console.ReadLine();
}