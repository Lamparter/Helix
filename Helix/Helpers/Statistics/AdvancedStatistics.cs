using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Helpers.Statistics
{
    public static class AdvancedStatistics
    {
        public static double StandardDeviation(List<double> data)
        {
            double mean = StatisticalAnalysis.CalculateMean(data);
            double sumSquaredDifferences = data.Sum(d => Math.Pow(d - mean, 2));
            return Math.Sqrt(sumSquaredDifferences / data.Count);
        }

        public static double CorrelationCoefficient(List<double> dataX, List<double> dataY)
        {
            if (dataX.Count != dataY.Count)
                throw new ArgumentException("Data sets must have the same number of elements");

            double meanX = StatisticalAnalysis.CalculateMean(dataX);
            double meanY = StatisticalAnalysis.CalculateMean(dataY);

            double sumXY = 0, sumX2 = 0, sumY2 = 0;
            for (int i = 0; i < dataX.Count; i++)
            {
                double xDiff = dataX[i] - meanX;
                double yDiff = dataY[i] - meanY;

                sumXY += xDiff * yDiff;
                sumX2 += xDiff * xDiff;
                sumY2 += yDiff * yDiff;
            }

            return sumXY / Math.Sqrt(sumX2 * sumY2);
        }
    }
}
