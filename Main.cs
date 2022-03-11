using System;
using System.Collections.Generic;
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

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool BnFigureClicked;
        double DeltaX, DeltaY;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (BnFigureClicked)
                MyBnFigure.Margin = new Thickness(e.GetPosition(this).X - DeltaX,
                    e.GetPosition(this).Y - DeltaY, 0, 0);
        }

        private void MyBnFigure_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ButtonState == e.LeftButton)
            {
                StackPanel.SetZIndex(MyBnFigure, 1);
                BnFigureClicked = true;
                DeltaX = e.GetPosition(this).X - MyBnFigure.Margin.Left;
                DeltaY = e.GetPosition(this).Y - MyBnFigure.Margin.Top;
            }
        }

        private void MyBnFigure_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BnFigureClicked = false;
            MyBnFigure.Margin = new Thickness(
                (int)(MyBnFigure.Margin.Left + 25) / 50 * 50, (int)(MyBnFigure.Margin.Top + 25) / 50*50, 0, 0);
        }

       
    }
}
