using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace wpfXamlToPNG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, RoutedEventArgs e)

        {
            var pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            var bmp = new Bitmap(100, 100);
            var gr = Graphics.FromImage(bmp);
            gr.DrawLine(pen,0,0,50,50);
            bmp.Save(@"D:\test.png");
        }
    }
}
