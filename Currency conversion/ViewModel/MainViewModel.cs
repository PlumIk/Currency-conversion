namespace Currency_conversion
{
    internal class MainViewModel : MainViewModelBase
    {
        private double _value1 = 1;
        private double _value2 = 1;
        private SwapViewModel _swapViewModel = new SwapViewModel();
        private CustomConvector _customConvector = null;

        public void init()
        {
            _swapViewModel.init();
            _customConvector = _swapViewModel.GetCustomConvector();
        }
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
                    _value2 = _customConvector.Convert(_value1, Type1, Type2);
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
                    _value1 = _customConvector.Convert(_value2, Type2, Type1);
                    OnPropertyChanged("Value1");
                    OnPropertyChanged("Value2");
                }
            }
        }

        public string Type1
        {
            get
            {
                return _swapViewModel.Type1;
            }
            set{}
        }

        public string Type2
        {
            get
            {
                return _swapViewModel.Type2;
            }
            set{}
        }

        public SwapViewModel GetSwapViewModel()
        {
            return _swapViewModel;
        }
        public void SetSwapViewModel(SwapViewModel swapViewModel)
        {
            _swapViewModel= swapViewModel;
            _customConvector = swapViewModel.GetCustomConvector();
            _value2 = _customConvector.Convert(_value1, Type1, Type2);
            OnPropertyChanged("Value2");
            OnPropertyChanged("Type1");
            OnPropertyChanged("Type2");
        }

        public void SwapLeft(bool value)
        {
            if (value)
                _swapViewModel.IsLeft = true;
            else
                _swapViewModel.IsRight = true;
        }
    }
}
