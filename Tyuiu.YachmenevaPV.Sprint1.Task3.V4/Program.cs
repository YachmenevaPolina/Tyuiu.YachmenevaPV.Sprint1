using Tyuiu.YachmenevaPV.Sprint1.Task3.V4.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Операторы составного присваивания.                                *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #4                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
    Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    double priceNotebook = 2.75;
    double priceCover = 0.5;
    int quantity = 7;
    Console.WriteLine("Цена тетради (руб.) -> " + priceNotebook);
    Console.WriteLine("Цена обложки (руб.) -> " + priceCover);
    Console.WriteLine("Количество комплектов (шт.) -> " + quantity);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Стоимость покупки: " + ds.PurchaseAmount(priceNotebook, priceCover, quantity) + "руб.");

    Console.ReadKey();

}