using tyuiu.cources.programming.interfaces.Sprint1;
using System;

namespace Tyuiu.AxyonovMA.Sprint1.Task7.V12.Lib
{
    public class DataService : ISprint1Task7V12
    {
        public double Calculate(double x, double y)
        {
            double part1 = Math.Pow((x + 1) / (x - 1), x);
            double part2 = 18 * x * Math.Pow(y, 2);
            return Math.Round(part1 + part2, 3);
        }
    }
}