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
            var datapoints = txtXaml.Text.Split(' ');
            var pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            var bmp = new Bitmap(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            var gr = Graphics.FromImage(bmp);
            var dataPoints = datapoints.Select(point => new DataPoints(point)).ToList();
            gr.DrawLine(pen, 0, 0, 50, 50);
            bmp.Save(@"D:\test.png");
        }
    }
}     