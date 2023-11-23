using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TaturinAM.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            string srtX = File.ReadAllText(path);

            double res = Math.Pow(Convert.ToDouble(srtX), 3) - Math.Tan(Convert.ToDouble(srtX)) + 2.03 * Convert.ToDouble(srtX);

            return Math.Round(res, 3);
            
        }
    }
}
