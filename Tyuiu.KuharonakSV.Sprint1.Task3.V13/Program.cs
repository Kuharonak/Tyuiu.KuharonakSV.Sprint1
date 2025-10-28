using Tyuiu.KuharonakSV.Sprint1.Task3.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Кухаронак С В | СМАРТБ-25-1;";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема:  Организация ввода/вывода в консольных приложениях                *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Кухароеак Сергей Витальевич | СМАРТБ-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая позволяет найти произведение цифр,          *");
        Console.WriteLine("* заданного трехзначного числа                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x = 634;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Исходное число--"+x);
        Console.WriteLine("Произведение="+ds.MultiplyOfDigits(x));

        Console.ReadLine();
    }
}