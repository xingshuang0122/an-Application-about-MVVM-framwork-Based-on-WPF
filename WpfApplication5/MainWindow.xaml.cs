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
using System.Windows.Threading;

namespace WpfApplication5
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 10;
        /// <summary>
        /// 创建Timer对象
        /// </summary>
        private DispatcherTimer timer = null;

        public MainWindow( )
        {
            InitializeComponent( );
        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            this.timer = new DispatcherTimer( );
            this.timer.Interval = TimeSpan.FromSeconds( 1 );
            this.timer.Tick += new EventHandler( timer_tick );
            this.timer.Start( );
        }

        private void timer_tick( object sender, EventArgs e )
        {
            if (count == 0)
            {
                timer.Stop( );
                count = 10;
                timer.Start( );
            }
            else
            {
                TextCtl txt = new TextCtl( this.rootGrid, wm );
                txt.TxtValue = count.ToString( );
                txt.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                txt.VerticalAlignment = System.Windows.VerticalAlignment.Center;
                this.rootGrid.Children.Add( txt );
                count--;
            }
        }
    }
}
