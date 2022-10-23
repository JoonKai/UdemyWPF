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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07_SimpleAnimationCSharp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation fadeAnimation = new DoubleAnimation();
            fadeAnimation.Duration = TimeSpan.FromSeconds(1.0d);
            fadeAnimation.From = 0.0d;
            fadeAnimation.To = 1.0d;
            MainGrid.BeginAnimation(Grid.OpacityProperty, fadeAnimation);
        }

        private void MainGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            DoubleAnimation fadeAnimation = new DoubleAnimation(1.0d,0.5d,TimeSpan.FromSeconds(2));
            MainGrid.BeginAnimation(Grid.OpacityProperty, fadeAnimation);
        }
    }
}
