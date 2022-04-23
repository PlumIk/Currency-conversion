using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    internal class CustomConvector
    {
        private readonly Dictionary<string, double> _valuePairs = new Dictionary<string, double>();
        public readonly List<string> _idName = new List<string>();

        public CustomConvector()
        {
            _idName.Add("RU");
            _valuePairs["RU"] = 1;
            _idName.Add("USD");
            _valuePairs["USD"] = 75;

        }
        private double ConvertToZero(double value, string type)
        {
            double ret = value;
            if (type != null && value != 0)
            {
                ret *= _valuePairs[type];
            }
            else
            {
                ret = -1;
            }


            return ret;
        }

        private double ConvertFromZero(double value, string type)
        {
            double ret = value;
            if (type != null && value != 0)
            {
                ret /= _valuePairs[type];
            }
            else
            {
                ret = -1;
            }


            return ret;
        }

        public double Convert(double value1, string type1, string type2)
        {
            return ConvertFromZero(ConvertToZero(value1, type1), type2);
        }

    }
}
