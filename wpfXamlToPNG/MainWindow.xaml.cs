using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows;

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
            var startPoints = new DataPoints();
            var currentPoints = new List<(double,double)>();
            var currentCommand = "";
            var datapoints = txtXaml.Text.Split(' ');
            var pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            var bmp = new Bitmap(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            var gr = Graphics.FromImage(bmp);
            var dataPoints = datapoints.Select(point => new DataPoints(point)).ToList();
            //Figure out best way to go through list and get each item
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
                    startPoints = point;  
                }
                else if (point.GetCommand() != null)
                {
                    currentCommand = point.GetCommand();
                    currentPoints = new List<(double, double)>();
                }
                currentPoints.Add(point.GetPoints());

                if (currentCommand == "L")
                {
                    
                         gr.DrawLine(pen, (float) startPoints.GetPoints().Item1, (float) startPoints.GetPoints().Item2, (float) currentPoints[0].Item1, (float)currentPoints[0].Item2);
                }
                
            }

       
            bmp.Save(@"D:\test.png");
        }

        private void DrawCurrentPoints()
        { }
    }
}     