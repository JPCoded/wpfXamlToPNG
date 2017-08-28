using System.Drawing;
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
            var pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            var bmp = new Bitmap(100, 100);
            var gr = Graphics.FromImage(bmp);
            gr.DrawLine(pen, 0, 0, 50, 50);
            bmp.Save(@"D:\test.png");
        }
    }
}