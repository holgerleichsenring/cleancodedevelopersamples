using System;

namespace CodingSamples.RussianPeasantMultiplication
{
    /// <summary>
    /// Calculates the russian farmer multiplication by two factors
    /// 1. dividing x by 2 as long as is more than 1
    /// 2. double the value of y while upper condition is true
    /// 3. sum all values of y while x is more than 1 and is uneven
    /// 4. return resulting sum
    /// </summary>
    public class RussianPeasantMultiplicationCalculator
    {
        /// <summary>
        /// multiply two factors and return the result.
        /// </summary>
        /// <param name="x">value to be devided by 2 while is larger than 1</param>
        /// <param name="y">value to be doubled</param>
        /// <returns>sum all values of y while calculation where x is more than 1 and is uneven</returns>
        public int Mul(int x, int y)
        {
            if (x < 1)
            {
                throw new ArgumentException("x must be larger than 1", nameof(x));
            }

            int sumOfYWhereXIsUneven = 0;
            int currentX = x;
            int currentY = y;

            CalculateSum(ref sumOfYWhereXIsUneven, currentX, currentY);
            do
            {
                currentX = DevideBy2AndRound(currentX);
                currentY = MultiplyBy2(currentY);
                CalculateSum(ref sumOfYWhereXIsUneven, currentX, currentY);

            } while (currentX > 1);

            return sumOfYWhereXIsUneven;
        }

        private void CalculateSum(ref int sum, int x, int y)
        {
            if (x % 2 != 0)
            {
                sum += y;
            }
        }

        private int DevideBy2AndRound(int value)
        {
            double divisionResult = value / 2;
            double roundedResult = Math.Round(divisionResult);
            return Convert.ToInt32(roundedResult);
        }

        private int MultiplyBy2(int value)
        {
            return value * 2;
        }
    }
}
