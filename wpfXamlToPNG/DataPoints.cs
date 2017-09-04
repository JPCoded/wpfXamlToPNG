using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfXamlToPNG
{
    public class DataPoints
    {
        private string command;
        private double pointone;
        private double pointtwo;

        public DataPoints( string Points)
        {

        }

        (double, double) GetPoints() => (pointone, pointtwo);

      public  void SetPoints(string PointsToSet)
        {
            
        }
    }
}
