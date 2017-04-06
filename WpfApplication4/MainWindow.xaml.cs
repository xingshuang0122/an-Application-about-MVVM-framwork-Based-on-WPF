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

namespace WpfApplication4
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

        private void Storyboard_CurrentTimeInvalidated( object sender, EventArgs e )
        {
            Clock storyboardClock = (Clock)sender;

            if(storyboardClock.CurrentProgress==null)
            {
                this.lblTime.Content = "[[Stopped]]";
                this.pgsbTime.Value = 0;
            }
            else
            {
                this.lblTime.Content = storyboardClock.CurrentTime.ToString( );
                this.pgsbTime.Value = (double)storyboardClock.CurrentProgress;
            }
        }
    }
}
