using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DewjaterikowaAA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double f = (Math.Cos(Math.Pow(x, 2)) + Math.Sin(Math.Pow(y, 2))) / (Math.Sin(y) + 1);
            double k = (x * y - 12) / (15 + Math.Cos(x));
            double s = f - k;
            return Math.Round(s, 3);
        }
    }
}
