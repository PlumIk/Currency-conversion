using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    internal class MainViewModel : MainViewModelBase
    {
        private double _value1 = 1;
        private double _value2 = 1;
        public double Value1
        {
            get
            {
                return _value1;
            }
            set
            {
                if (_value1 != value)
                {
                    _value1 = value;
                    _value2 = _value1;
                    OnPropertyChanged("Value1");
                    OnPropertyChanged("Value2");
                }
            }
        }

        public double Value2
        {
            get
            {
                return _value2;
            }
            set
            {
                if (_value2 != value)
                {
                    _value2 = value;
                    _value1 = _value2;
                    OnPropertyChanged("Value1");
                    OnPropertyChanged("Value2");
                }
            }
        }
    }
}
