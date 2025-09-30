using Tyuiu.YachmenevaPV.Sprint1.Task5.V6.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Преобразование типов и класс Convert.                             *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #6                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
    Console.WriteLine("* Пусть k - целое от 1 до 365. Присвоить целой переменной n значение      *");
    Console.WriteLine("* 1, 2, ...., 7 в зависимости от того, на какой день недели приходится    *");
    Console.WriteLine("* k-й день невисокосного года, в котором 1 января - понедельник.          *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите число k (1...365): ");
    int k = Convert.ToInt32(Console.ReadLine());

    int day = Convert.ToInt32(ds.Calculate(k));

    Console.WriteLine($"День недели для {k}-го дня: {day}");

    Console.ReadKey();
}