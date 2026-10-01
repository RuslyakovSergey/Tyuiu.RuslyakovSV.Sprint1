using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RuslyakovSV.Sprint1.Task4.V9.Lib
{
    public class DataService : ISprint1Task4V9
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Log(x * y) / (x - Math.Sqrt(1 + y * y)), 3);
        }
    }
}
