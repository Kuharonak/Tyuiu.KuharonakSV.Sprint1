using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KuharonakSV.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double a)
        {
            double res = (1+Math.Cos(a)) / Math.Pow(Math.Sin(a), 2);
            return Math.Round(res, 3);
        }
    }
}
