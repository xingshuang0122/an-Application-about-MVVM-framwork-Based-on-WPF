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

namespace WpfApplication3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow( )
        {
            InitializeComponent( );
        }

        private void btnTest_Click( object sender, RoutedEventArgs e )
        {
            DoubleAnimation widthAnimation = new DoubleAnimation( );
            widthAnimation.From = 60;
            widthAnimation.To = this.Width - 50;
            widthAnimation.Duration = TimeSpan.FromSeconds( 5 );
            //widthAnimation.RepeatBehavior = RepeatBehavior.Forever;
            widthAnimation.RepeatBehavior = new RepeatBehavior( TimeSpan.FromSeconds( 10 ) );
            widthAnimation.AutoReverse = true;
            //widthAnimation.FillBehavior = FillBehavior.Stop;
            widthAnimation.SpeedRatio = 1;
            btnTest.BeginAnimation( Button.WidthProperty, widthAnimation );

            //DoubleAnimation heightAnimation = new DoubleAnimation( );
            //heightAnimation.From = 60;
            //heightAnimation.To = this.Height - 100;            
            //heightAnimation.Duration = TimeSpan.FromSeconds( 5 );
            //heightAnimation.RepeatBehavior = RepeatBehavior.Forever;
            //heightAnimation.AutoReverse = true;
            //btnTest.BeginAnimation( Button.HeightProperty, heightAnimation );
        }
    }
}
