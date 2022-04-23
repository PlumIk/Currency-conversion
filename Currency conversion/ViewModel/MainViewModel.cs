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
        private string _type1 = "RU";
        private string _type2 = "RU";
        public bool swapLeft = false;
        public bool swapRight = false;
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

        public string Type1
        {
            get
            {
                return _type1;
            }
            set
            {
                if (_type1 != value)
                {
                    _type1 = value;
                    OnPropertyChanged("Type1");
                }
            }
        }

        public string Type2
        {
            get
            {
                return _type2;
            }
            set
            {
                if (_type2 != value)
                {
                    _type2 = value;
                    OnPropertyChanged("Type2");
                }
            }
        }
    }
}
