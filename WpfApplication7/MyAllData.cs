using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    public class MyAllData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private string strName;
        public string Name
        {
            get {  return strName; }

            set
            {
                this.strName = value;
                if (PropertyChanged != null)
                {
                    // 引发PropertyChanged事件，
                    // PropertyChangedEventArgs构造方法中的参数字符串表示属性名
                    PropertyChanged( this, new PropertyChangedEventArgs( "Name" ) );
                }
            }
        }

        public MyAllData()
        {
            Name = "xingshuang";
        }       
    }
}
