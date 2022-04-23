using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Currency_conversion.ViewModel.Converters
{
    internal class StringToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string one = (string)value;
            double ret;
            if( Double.TryParse(one, out ret))
            {
                return ret;
            }
            return -1;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            double one = (double)value;
            if(one < 0)
            {
                return "Невозможно перевести";
            }
            return one.ToString();
        }
    }
}
