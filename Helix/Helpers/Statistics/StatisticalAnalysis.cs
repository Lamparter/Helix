using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace Helix.Helpers.Statistics
{
    public static class StatisticalAnalysis
    {
        public static double CalculateMean(List<double> data)
        {
            return data.Average();
        }

        public static double CalculateMedian(List<double> data)
        {
            var sortedData = data.OrderBy(n => n).ToList();
            int count = sortedData.Count();
            if (count % 2 == 0)
            {
                return (sortedData[count / 2 - 1] + sortedData[count / 2]) / 2;
            }
            return sortedData[count / 2];
        }
    }
}