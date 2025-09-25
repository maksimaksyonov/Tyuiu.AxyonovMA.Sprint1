using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AxyonovMA.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHours(double f)
        {
            // За 12 часов часовая стрелка проходит 360 градусов
            // 1 час = 30 градусов (360 / 12 = 30)
            // h = f / 30
            int hours = (int)(f / 30);
            return hours;
        }

        public int AngleToHoursMinutes(double f)
        {
            int hours = (int)(f / 30);
            return hours;
        }
    }
}