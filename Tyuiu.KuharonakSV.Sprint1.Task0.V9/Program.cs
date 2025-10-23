using Tyuiu.KuharonakSV.Sprint1.Task0.V9.Lib;

internal class Program


{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #0 | Выполнил: Кухаронак С. В. | СМАРТб-25-1 ";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич |СМАРТб-25-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение (9/3)*4/3/2+1           *");
        Console.WriteLine("*  и печатает результат на экране                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("(9/3)*4/3/2+1                                                             *");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}