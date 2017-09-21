using System.Collections.Generic;
using System.Drawing;
using Pen = System.Drawing.Pen;

namespace wpfXamlToPNG
{
    public static class GraphicsExtensions
    {
        // Draw a RectangleF.
        public static void DrawXaml(this Graphics gr,
            Pen pen, List<(double, double)> currentPoints, (double, double) startPoints, string currentCommand)
        {
            if (currentCommand == "M")
            {

            }
            if (currentCommand == "L")
            {

            }
            if (currentCommand == "C")
            {
                gr.DrawBezier(pen, (float)startPoints.Item1, (float)startPoints.Item2,
                    (float)currentPoints[0].Item1, (float)currentPoints[0].Item2,
                    (float)currentPoints[1].Item1, (float)currentPoints[1].Item2,
                    (float)currentPoints[2].Item1, (float)currentPoints[2].Item2);
            }
        }
    }
}