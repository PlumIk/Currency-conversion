using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_conversion
{
    internal class CustomConvector
    {
        private readonly Dictionary<string, double> _valuePairs ;
        public readonly List<string> _idName ;

        public CustomConvector( DataGet dataGet)
        {
            _idName = dataGet.GetNames();
            _valuePairs = dataGet.GetValues();

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
