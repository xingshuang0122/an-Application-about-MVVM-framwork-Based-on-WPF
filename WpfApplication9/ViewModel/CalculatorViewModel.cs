using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication9.BaseClassLib;
using WpfApplication9.Model;

namespace WpfApplication9.ViewModel
{
    public class CalculatorViewModel : BaseNotifyPropertyChanged
    {
        public CalculatorViewModel( )
        {
            this._calModel = new CalculatorModel( );
        }

        #region 将要绑定的数据
        private CalculatorModel _calModel;
        /// <summary>
        /// 计算器数据类
        /// </summary>
        public CalculatorModel CalModel
        {
            get
            {
                return _calModel;
            }

            set
            {
                this._calModel = value;
                RaisePropertyChanged( "CalModel" );
            }
        }
        #endregion

        #region 将要绑定的命令

        /// <summary>
        /// 计算命令
        /// </summary>
        private MyCommand _calculatorCommand;
        public MyCommand CalculatorCommand
        {
            get
            {
                if (this._calculatorCommand == null)
                {
                    this._calculatorCommand = new MyCommand( this.ExecuteCalculate );
                }
                return this._calculatorCommand;
            }
        }

        /// <summary>
        /// 重置命令
        /// </summary>
        private MyCommand _restartCommand;
        public MyCommand RestartCommand
        {
            get
            {
                if (this._restartCommand == null)
                {
                    this._restartCommand = new MyCommand( this.ExecuteRestart );
                }
                return _restartCommand;
            }
        }

        #endregion

        #region 相关的功能函数
        /// <summary>
        /// 执行计算功能
        /// </summary>
        private void ExecuteCalculate( object strParameter = null )
        {
            this._calModel.Result = this._calModel.Number1 + this._calModel.Number2;
        }


        /// <summary>
        /// 执行重置功能
        /// </summary>
        private void ExecuteRestart( object strParameter = null )
        {
            this._calModel.Number1 = 0;
            this._calModel.Number2 = 0;
            this._calModel.Result = 0;
        }
        #endregion
    }
}
