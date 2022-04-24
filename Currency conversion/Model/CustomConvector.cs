using System.Collections.Generic;

namespace Currency_conversion
{
    internal class CustomConvector
    {
        private readonly Dictionary<string, double> _values ;
        public readonly List<string> _shortNames ;
        public readonly Dictionary<string,string> _names ;

        public CustomConvector( DataGet dataGet)
        {
            _shortNames = dataGet.GetShortNames();
            _values = dataGet.GetValues();
            _names = dataGet.GetNames();

        }
        private double ConvertToAbsolute(double value, string type)
        {
            double ret = value;
            if (type != null && value != 0)
            {
                ret *= _values[type];
            }
            else
            {
                ret = -1;
            }


            return ret;
        }

        private double ConvertFromAbsolute(double value, string type)
        {
            double ret = value;
            if (type != null && value != 0)
            {
                ret /= _values[type];
            }
            else
            {
                ret = -1;
            }


            return ret;
        }

        public double Convert(double value1, string type1, string type2)
        {
            return ConvertFromAbsolute(ConvertToAbsolute(value1, type1), type2);
        }

    }
}
