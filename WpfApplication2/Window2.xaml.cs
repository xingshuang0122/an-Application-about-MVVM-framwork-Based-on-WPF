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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2( )
        {
            InitializeComponent( );
        }

        protected int eventCount = 0;
        private void SomethingClicked( object sender, MouseButtonEventArgs e )
        {
            eventCount++;
            string message = "#" + eventCount.ToString( ) + ":\r\n" +
                " Sender " + sender.ToString( ) +"\r\n"+
                " Source " +e.Source+"\r\n"+
                " Original Source: " +e.OriginalSource;
            this.lstMessage.Items.Add( message );
            e.Handled = (bool)chkHandle.IsChecked;
        }

        private void cmdClear_Click( object sender, RoutedEventArgs e )
        {

        }
    }
}
