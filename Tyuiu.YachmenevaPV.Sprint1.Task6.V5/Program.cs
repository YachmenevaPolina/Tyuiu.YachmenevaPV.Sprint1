using Tyuiu.YachmenevaPV.Sprint1.Task6.V5.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Работа со строками класса String.                                 *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #5                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
    Console.WriteLine("* которые являются симметричными.                                         *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите текст: ");
    string input = Console.ReadLine();

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(ds.CheckSymmetricalWords(input));
    Console.ReadKey();

}