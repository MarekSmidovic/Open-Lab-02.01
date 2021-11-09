using System;

namespace Open_Lab_02._01
{
    public class Exercise
    {
        public double[] Create5Numbers()
        {
            double[] zoznam = { 1.11, 2.22, 3.33, 4.44, 5.55 };
            return zoznam;
        }

        public double GetSecond(double[] numbers)
        {
            return numbers[1];
        }
    }
}