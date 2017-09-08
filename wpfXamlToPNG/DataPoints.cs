using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfXamlToPNG
{
    public class DataPoints
    {
        private string _command = null;
        private double _pointone;
        private double _pointtwo;

        public DataPoints()
        {
        }

        public DataPoints( string points) => ParsePoints(points);

        

        private void ParsePoints(string points)
        {
            if (points.StartsWith("M") || points.StartsWith("m"))
            {
                _command = "M";
                points = points.Replace("M", "");
            }
            var newPoints = points.Split(',');
            _pointone = Convert.ToDouble(newPoints[0]);
            _pointtwo = Convert.ToDouble(newPoints[1]);
        }

        public void AddPoints(string points) => ParsePoints(points);
       public (double, double) GetPoints() => (_pointone, _pointtwo);
        public string GetCommand() => _command;

    }
}                  
