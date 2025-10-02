using Tyuiu.YachmenevaPV.Sprint1.Task7.V9.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов.                           *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #9                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
    Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("             2      3           2");
    Console.WriteLine("      x     y + cosx + 12xy - 3x");
    Console.WriteLine("z = e  - --------------------------------");
    Console.WriteLine("                 3");
    Console.WriteLine("            cos(x + 3) + 18y - 1");
    
    double x, y;

    Console.WriteLine("Введите значение Х:");
    x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение Y:");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.Calculate(x, y));
    Console.ReadKey();
}