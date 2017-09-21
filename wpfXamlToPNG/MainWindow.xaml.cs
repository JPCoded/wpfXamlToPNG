using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace wpfXamlToPNG
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)
        {
            (double, double) startPoints = (0, 0);
            (double, double) currentStartPoints = (0, 0);
            var currentPoints = new List<(double, double)>();
            var currentCommand = "";
            var datapoints = txtXaml.Text.Split(' ');
            var pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            var bmp = new Bitmap(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            var gr = Graphics.FromImage(bmp);
            var dataPoints = datapoints.Select(point => new DataPoints(point)).ToList();
            //Figure out best way to go through list and get each item
            /**
  * L EndPoint, EndPoint  -- Line
  * H EndPoint  -- Horizontal Line
  * V EndPoint  -- Vertical Line
  * C ControlPoint, ControlPoint, EndPoint -- Cubic Bezier Curve
  * 
  */
            /**
             * Check current Command
             * If M, set start point
             * Else if L or C set command to that
             * If current command not changed, put new point into point array?
             * If current command changed, take the current points and draw circle or line?
             * 
             * 
             */

            foreach (var point in dataPoints)
            {
                if (point.GetCommand() == "M")
                {
                    startPoints = point.GetPoints();
                    currentStartPoints = point.GetPoints();
                }
                else if (point.GetCommand() != null && currentCommand != point.GetCommand())
                {

                          gr.DrawXaml(pen, currentPoints, ref currentStartPoints, currentCommand);                       
                    currentCommand = point.GetCommand();
                    currentPoints = new List<(double, double)>();
                }

                currentPoints.Add(point.GetPoints());
            }


            gr.Dispose();
            bmp.Save(@"D:\test.png");
        }
    }
}