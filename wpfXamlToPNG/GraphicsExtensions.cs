using System.Collections.Generic;
using System.Drawing;
using Pen = System.Drawing.Pen;

namespace wpfXamlToPNG
{
    public static class GraphicsExtensions
    {
        // Draw a RectangleF.
        public static void DrawXaml(this Graphics gr,
            Pen pen, List<(double, double)> currentPoints, ref (double, double) currentStartPoints, string currentCommand)
        {
            if (currentCommand == "M")
            {

            }
            if (currentCommand == "L")
            {
                foreach (var cPoint in currentPoints )
                {
                    gr.DrawLine(pen, (float)currentStartPoints.Item1, (float)currentStartPoints.Item2, (float)cPoint.Item1, (float)cPoint.Item2);
                    currentStartPoints = cPoint;
                }
                
            }
            if (currentCommand == "C")
            {
                while (currentPoints.Count > 0)
                {
                    gr.DrawBezier(pen, (float) currentStartPoints.Item1, (float) currentStartPoints.Item2,
                        (float) currentPoints[0].Item1, (float) currentPoints[0].Item2,
                        (float) currentPoints[1].Item1, (float) currentPoints[1].Item2,
                        (float) currentPoints[2].Item1, (float) currentPoints[2].Item2);
                    currentPoints.RemoveRange(0, 3);
                }
            }
        }
    }
}