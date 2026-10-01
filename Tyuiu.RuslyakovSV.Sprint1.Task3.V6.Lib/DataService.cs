using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RuslyakovSV.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            return Math.Round(distance * 2 * gasFlow / 100 * gasPrice, 3);
        }
    }
}
