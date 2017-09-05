using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfXamlToPNG
{
    public class DataPoints
    {
        private readonly string _command = null;
        private readonly double _pointone;
        private readonly double _pointtwo;

        public DataPoints( string points)
        {
           
            if (points.StartsWith("M") || points.StartsWith("m"))
            {
                _command = "M";
                points = points.Replace("M", "");
            }
           var newPoints = points.Split(',');
            _pointone =Convert.ToDouble(newPoints[0]);
            _pointtwo = Convert.ToDouble(newPoints[1]);

        }

       public (double, double) GetPoints() => (_pointone, _pointtwo);
        public string GetCommand() => _command;

    }
}                  
