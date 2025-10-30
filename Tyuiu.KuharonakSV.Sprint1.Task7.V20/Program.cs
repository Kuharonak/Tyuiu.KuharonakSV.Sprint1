using Tyuiu.KuharonakSV.Sprint1.Task7.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил Кухаронак С.В. | СМАРТБ-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* спринт #1                                                               *");
        Console.WriteLine("* Тема : Добавление к решению итоговых проектов по спринту                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич | СМАРТБ-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение          *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                   *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x = 0;
        double y = 0;


        Console.WriteLine("Введите значение x: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение y: ");
        x = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}