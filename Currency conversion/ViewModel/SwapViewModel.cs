using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    internal class SwapViewModel: MainViewModelBase
    {
        private string _type1 = "RU";
        private string _type2 = "RU";
        public CustomConvector _customConvector = null;
        public bool IsLeft = false;
        public bool IsRight = false;

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

        public List<string> GetId()
        {
            return new List<string>(_customConvector._shortNames.Select(x => x.ToString()));
        }

        public void FillMe(SwapViewModel swapViewModel)
        {
            _type1=swapViewModel.Type1;
            _type2=swapViewModel.Type2;
            _customConvector = swapViewModel._customConvector;
            IsLeft=swapViewModel.IsLeft;
            IsRight=swapViewModel.IsRight;
        }

    }
}
