using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AxyonovMA.Sprint1.Task2.V3.Lib
{
    public class DataService : ISprint1Task2V3
    {
        public int ConvertHoursToMinutes(int value)
        {
            return value * 60;
        }

        public int ConvertHourToMin(int value)
        {
            throw new NotImplementedException();
        }
    }
}