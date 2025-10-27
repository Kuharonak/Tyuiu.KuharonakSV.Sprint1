using Tyuiu.KuharonakSV.Sprint1.Task1.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Кухаронак С. В. | СМАРТб-25-1 ";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич |СМАРТб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
        Console.WriteLine("* вычисляет результат по формуле x/3/y+6*a                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y, a;
        Console.WriteLine("Введите значение x");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y, a));
        Console.ReadLine();


    }
}