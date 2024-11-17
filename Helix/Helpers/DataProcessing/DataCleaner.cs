using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Helpers.DataProcessing
{
    public static class DataCleaner
    {
        public static string CleanStringData(string data)
        {
            return data.Trim().Replace("\n", " ").Replace("\r", " ");
        }

        public static List<T> RemoveDuplicates<T>(List<T> data)
        {
            return data.Distinct().ToList();
        }
    }
}