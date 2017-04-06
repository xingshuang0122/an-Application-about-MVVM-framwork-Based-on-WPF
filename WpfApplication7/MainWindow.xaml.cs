using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApplication7
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
        public MyAllData myAllData;
        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            myAllData = new MyAllData( );
            this.DataContext = myAllData;
        }

        private void btn3_Click( object sender, RoutedEventArgs e )
        {
            string str1 = "xing";
            string str2 = "shuang";
            string str3 = $"{str1} + {str2} is a man!";
            this.myAllData.Name = string.Format( "English" );
            MessageBox.Show( str3 );
        }

        private void btn2_Click( object sender, RoutedEventArgs e )
        {
            //MyHuman myHm = this.FindResource( "human" ) as MyHuman;
            //MessageBox.Show( myHm.Child.Name );
        }
       
    }
    public class StringToHumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom( ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value )
        {
            if (value is string)
            {
            MyHuman human = new MyHuman( );
            human.Name = value as string;
            return human;
            }
            return base.ConvertFrom( context, culture, value );
        }
    }

    [TypeConverter( typeof( StringToHumanTypeConverter ) )]
    public class MyHuman
    {
        public string Name { get; set; }
        public MyHuman Child { get; set; }
    }
}
