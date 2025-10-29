using Tyuiu.KuharonakSV.Sprint1.Task6.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Кухаронак С. В. | СМАРТБ-25-1;";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #13                                                            *");
        Console.WriteLine("* Выполнил: Кухаронак Сергей Витальевич | СМАРТБ-25-1                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу: пользователь вводит текст. Проверить, что буквы     *");
        Console.WriteLine("*строки упорядочены по алфавиту                                          *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine();
        bool res = ds.CheckWordsAlphabet(str);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}