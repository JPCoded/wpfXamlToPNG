using System;

namespace wpfXamlToPNG
{
    public sealed class DataPoints : IDataPoints
    {
        private string _command = null;
        private double _pointone;
        private double _pointtwo;

        public DataPoints()
        {
        }

        public DataPoints( string points) => ParsePoints(points);


        public void ParsePoints(string points)
        {
            if (points.StartsWith("M"))
            {
                _command = "M";
                points = points.Replace("M", "");
            }
            else if (points.StartsWith("L"))
            {
                _command = "L";
                points = points.Replace("L", "");
            }
            else if (points.StartsWith("C"))
            {
                _command = "C";
                points = points.Replace("C","");
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
