using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication9.BaseClassLib;

namespace WpfApplication9.Model
{
    public class CalculatorModel : BaseNotifyPropertyChanged
    {
        public CalculatorModel()
        {
            this._number1 = 0;
            this._number2 = 0;
            this._result = 0;
        }

        private int _number1;
        /// <summary>
        /// 做运算的参数1
        /// </summary>
        public int Number1
        {
            get
            {
                return _number1;
            }

            set
            {
                this._number1 = value;
                RaisePropertyChanged( "Number1" );
            }
        }

        private int _number2;
        /// <summary>
        /// 做运算的参数2
        /// </summary>
        public int Number2
        {
            get
            {
                return _number2;
            }

            set
            {
                this._number2 = value;
                RaisePropertyChanged( "Number2" );
            }
        }

        private int _result;
        /// <summary>
        /// 运算结果
        /// </summary>
        public int Result
        {
            get
            {
                return _result;
            }

            set
            {
                this._result = value;
                RaisePropertyChanged( "Result" );
            }
        }
    }
}
